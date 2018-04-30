using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CCWin;
using System.IO;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.HSSF.UserModel;
using ZES_Exam.Model;
using System.Configuration;

namespace ZES_Exam
{
    public partial class StartPage : Skin_Mac
    {
        List<FileInfo> nameFile = new List<FileInfo>();
        List<FileInfo> paperFile = new List<FileInfo>();
        List<FileInfo> logFile = new List<FileInfo>();
        SettingModel settingModel;
        public static StartPage thisPage = null;
        public bool sideListShown = false;
        public bool listNoData = false;
        string logFileName = "";
        IWorkbook logWorkBook;
        IWorkbook nameWorkbook;
        List<int> allScoresColumn = new List<int>();
        public StartPage()
        {
            InitializeComponent();
            thisPage = this;
        }

        private void StartPage_Load(object sender, EventArgs e)
        {
            LookFile(0);
            LookFile(1);
            LookFile(2);

            settingModel = getSettings();
            try
            {
                
                if(settingModel != null)
                {
                    if(settingModel.nameFile.Length != 0)
                    {
                        bool hasGotIt = false;
                        for(int i = 0; i < nameComboBox.Items.Count; i++)
                        {
                            if(settingModel.nameFile.Split('\\')[settingModel.nameFile.Split('\\').Length - 1].Equals(nameComboBox.Items[i].ToString()))
                            {
                                nameComboBox.SelectedIndex = i;
                                hasGotIt = true;
                            }
                            if (hasGotIt)
                            {
                                break;
                            }
                        }
                        if (!hasGotIt)
                        {
                            nameComboBox.SelectedIndex = 0;
                        }
                    }
                    else
                    {
                        nameComboBox.SelectedIndex = 0;
                    }
                    if (settingModel.testFile.Length != 0)
                    {
                        bool hasGotIt = false;
                        for (int i = 0; i < examPaperComboBox.Items.Count; i++)
                        {
                            if (settingModel.testFile.Split('\\')[settingModel.testFile.Split('\\').Length - 1].Equals(examPaperComboBox.Items[i].ToString()))
                            {
                                examPaperComboBox.SelectedIndex = i;
                                hasGotIt = true;
                            }
                            if (hasGotIt)
                            {
                                break;
                            }
                        }
                        if (!hasGotIt)
                        {
                            examPaperComboBox.SelectedIndex = 0;
                        }
                    }
                    else
                    {
                        examPaperComboBox.SelectedIndex = 0;
                    }
                }
                
            }
            catch(Exception _e)
            {

            }
            findScores();
            checkStartButton();

        }

        public SettingModel getSettings()
        {
            SettingModel _settingModel = new SettingModel();
            int originalScore = 0;
            int.TryParse(ConfigurationManager.AppSettings["originalScore"], out originalScore);
            _settingModel.originalScore = originalScore;

            int singleQuestionScore = 0;
            int.TryParse(ConfigurationManager.AppSettings["singleQuestionScore"], out singleQuestionScore);
            _settingModel.singleQuestionScore = singleQuestionScore;

            bool scoreNoDeduction = false;
            bool.TryParse(ConfigurationManager.AppSettings["scoreNoDeduction"], out scoreNoDeduction);
            _settingModel.scoreNoDeduction = scoreNoDeduction;

            int countingTime = 0;
            int.TryParse(ConfigurationManager.AppSettings["countingTime"], out countingTime);
            _settingModel.countingTime = countingTime;

            int selectQuestionMode = 0;
            int.TryParse(ConfigurationManager.AppSettings["selectQuestionMode"], out selectQuestionMode);
            _settingModel.selectQuestionMode = selectQuestionMode;

            _settingModel.nameFile = ConfigurationManager.AppSettings["nameFile"];
            _settingModel.testFile = ConfigurationManager.AppSettings["testFile"];
            return _settingModel;
        }

        //找之前的计分
        public void findScores()
        {
            nameWorkbook = readData(nameFile[nameComboBox.SelectedIndex].FullName);
            ISheet sheet = nameWorkbook.GetSheetAt(0);
            List<int> columns = new List<int>();
            if (sheet.GetRow(1) == null)
            {  
                ListViewItem _lvi = new ListViewItem("暂无记录");
                listNoData = true;
                selectSavedScore_lv.Items.Add(_lvi);
            }
            else
            {
                bool hasGotIt = false;
                for (int i = 0; i < sheet.GetRow(1).LastCellNum; i++)
                {
                    if(sheet.GetRow(1).GetCell(i)!= null)
                    {
                        if (sheet.GetRow(1).GetCell(i).ToString().Contains("计分"))
                        {
                            int _count = i;
                            columns.Add(_count);
                            hasGotIt = true;
                            listNoData = false ;
                            try
                            {
                                ListViewItem _lvi = new ListViewItem(sheet.GetRow(1).GetCell(i).ToString().Trim().Split(',')[1]);
                                _lvi.SubItems.Add(sheet.GetRow(1).GetCell(i).ToString().Trim().Split(',')[2]);
                                selectSavedScore_lv.Items.Add(_lvi);
                            }catch(Exception e)
                            {
                                MessageBox.Show("读取计分记录出现问题，将不会读取记录。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                        }
                    }
                    else
                    {
                        continue;
                    }
                }
                if (!hasGotIt)
                {
                    ListViewItem _lvi = new ListViewItem("暂无记录");
                    listNoData = true;
                    selectSavedScore_lv.Items.Add(_lvi);
                }
            }
            //list
            allScoresColumn = columns;
            selectSavedScore_lv.Update();
        }


        //检索文件
        public void LookFile(int mode, string extraFolder = "")
        {//0名单 1题库
            string startPath = "";
            if(mode == 0)
            {
                startPath = "名单";
            }else if(mode == 1)
            {
                startPath = "题库";
            }else if(mode == 2)
            {
                startPath = "日志";
            }
            string pathname = Application.StartupPath + "\\" + startPath + "\\" + extraFolder;
            if (pathname.Trim().Length == 0)//判断文件名不为空
            {
                return;
            }
            DirectoryInfo _dir = new DirectoryInfo(pathname);
            FileInfo[] fileInfos;
            try
            {
                fileInfos = _dir.GetFiles();
                foreach (FileInfo _file in fileInfos)
                {
                    if (Path.GetExtension(_file.Name).Equals(".xlsx") ||
                        Path.GetExtension(_file.Name).Equals(".xls") ||
                        Path.GetExtension(_file.Name).Equals(".exp"))
                    {
                        if (mode == 0)
                        {
                            nameFile.Add(_file);
                        }
                        else if (mode == 1)
                        {
                            paperFile.Add(_file);
                        }else if(mode == 2)
                        {
                            logFile.Add(_file);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            if(mode == 0)
            {
                foreach(FileInfo _file in nameFile)
                {
                    nameComboBox.Items.Add(_file.Name);
                }
            }
            else if(mode == 1)
            {
                foreach (FileInfo _file in paperFile)
                {
                    examPaperComboBox.Items.Add(_file.Name);
                }
            }
            else if(mode == 2)
            {
                bool hasGotIt = false;
                foreach (FileInfo _file in logFile)
                {
                    if (hasGotIt)
                    {
                        break;
                    }
                    if (_file.FullName.Contains(DateTime.Now.ToString("yyyyMM")))
                    {
                        logWorkBook = readData(_file.FullName);
                        logFileName = _file.FullName;
                        hasGotIt = true;
                    }
                }
                if (!hasGotIt)
                {
                    logFileName = Application.StartupPath + "\\" + startPath + "\\" + "Log-" + DateTime.Now.ToString("yyyyMM") + ".xls";
                    //创建Excel文件名称
                    FileStream fs = File.Create(logFileName);
                    //创建工作薄
                    IWorkbook workbook = new HSSFWorkbook();
                    ISheet sheet = workbook.CreateSheet("log");
                    for(int k =0; k< 2; k++)
                    {
                        IRow row = sheet.CreateRow(k);
                        switch (k)
                        {
                            case 0:
                                row.CreateCell(0).SetCellValue("Log-" + DateTime.Now.ToString("yyyyMM"));
                                break;
                            case 1:
                                for(int m = 0; m<9; m++)
                                {
                                    switch (m)
                                    {
                                        case 0:
                                            row.CreateCell(m).SetCellValue("时间-time");
                                            sheet.SetColumnWidth(m, 30 * 256);
                                            break;
                                        case 1:
                                            row.CreateCell(m).SetCellValue("正答-rightOrWrong");
                                            sheet.SetColumnWidth(m, 30 * 256);
                                            break;
                                        case 2:
                                            row.CreateCell(m).SetCellValue("姓名-studentName");
                                            sheet.SetColumnWidth(m, 30 * 256);
                                            break;
                                        case 3:
                                            row.CreateCell(m).SetCellValue("人员所在文件-studentFile");
                                            sheet.SetColumnWidth(m, 30 * 256);
                                            break;
                                        case 4:
                                            row.CreateCell(m).SetCellValue("班组名-className");
                                            sheet.SetColumnWidth(m, 30 * 256);
                                            break;
                                        case 5:
                                            row.CreateCell(m).SetCellValue("试卷名-testName");
                                            sheet.SetColumnWidth(m, 30 * 256);
                                            break;
                                        case 6:
                                            row.CreateCell(m).SetCellValue("试卷文件-testFile");
                                            sheet.SetColumnWidth(m, 30 * 256);
                                            break;
                                        case 7:
                                            row.CreateCell(m).SetCellValue("问题名-questionName");
                                            sheet.SetColumnWidth(m, 30 * 256);
                                            break;
                                        case 8:
                                            row.CreateCell(m).SetCellValue("答案-rightAnswer");
                                            sheet.SetColumnWidth(m, 30 * 256);
                                            break;
                                    }
                                }
                                break;
                        }
                    }
                    //向excel文件中写入数据并保保存
                    workbook.Write(fs);
                    fs.Close();
                    //再读取一下
                    logWorkBook = readData(logFileName);
                }
            }
        }

        public IWorkbook readData(string fileName)
        {
            IWorkbook workbook = null;  //新建IWorkbook对象  
            try
            {
                FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
                if (fileName.IndexOf(".xlsx") > 0) // 2007版本  
                {
                    try
                    {
                        workbook = new XSSFWorkbook(fileStream);  //xlsx数据读入workbook  
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("文件出错："+e.ToString().Split('。')[0]+"\n"+ fileName);
                        return null;
                    }
                }
                else if (fileName.IndexOf(".xls") > 0) // 2003版本  
                {
                    try
                    {
                        workbook = new HSSFWorkbook(fileStream);  //xls数据读入workbook  
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("访问文件出错：\n" + e.ToString().Split('。')[0]);
                        return null;
                    }
                }
            }
            catch (IOException e)
            {
                MessageBox.Show("访问文件出错：\n" + e.ToString().Split('。')[0]);
                return null;
            }
            return workbook;
        }

        private void checkName_btn_Click(object sender, EventArgs e)
        {
            nameWorkbook = readData(nameFile[nameComboBox.SelectedIndex].FullName);
            StudentListCheck form = new StudentListCheck(nameWorkbook);
            form.Show();
        }

        private void checkStartButton()
        {
            if (nameComboBox.Text.Length == 0 ||
            examPaperComboBox.Text.Length == 0)
            {
                startButton.Enabled = false;
                selectScore_btn.Enabled = false;
            }
            else
            {
                startButton.Enabled = true;
                selectScore_btn.Enabled = true;
            }
            if(nameComboBox.Text.Length != 0)
            {
                checkName_btn.Enabled = true;
            }
            else
            {
                checkName_btn.Enabled = false ;
            }
        }

        private void skinComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkStartButton();
        }

        private void nameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkStartButton();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            nameWorkbook = readData(nameFile[nameComboBox.SelectedIndex].FullName);
            IWorkbook paperWorkbook = readData(paperFile[examPaperComboBox.SelectedIndex].FullName);
            if(nameWorkbook != null &&
                paperWorkbook != null)
            {
                int scoreColumn = 0;
                if (!listNoData && selectSavedScore_lv.SelectedItems.Count != 0)
                {
                    scoreColumn = allScoresColumn[selectSavedScore_lv.SelectedItems[0].Index];
                }
                MainPage page = new MainPage(thisPage,nameWorkbook,paperWorkbook, logWorkBook, settingModel,nameFile[nameComboBox.SelectedIndex].FullName, paperFile[examPaperComboBox.SelectedIndex].FullName, logFileName, scoreColumn);
                if (!page.getAnyException)
                {
                    page.Show();
                    this.Hide();
                }
            }
            else
            {
                if(nameWorkbook == null)
                {
                    MessageBox.Show("名单文件读取失败，无法开始答题");
                }
                else if(paperWorkbook == null)
                {
                    MessageBox.Show("试题文件读取失败，无法开始答题");
                }
                
            }
        }

        private void selectScore_btn_Click(object sender, EventArgs e)
        {
            if (!sideListShown)
            {
                sideListShown = true;
                selectSavedScore_lv.Visible = true;
                skinLabel5.Visible = true;
                this.Size = new Size(700,340);
            }
            else
            {
                sideListShown = false;
                selectSavedScore_lv.Visible = false;
                skinLabel5.Visible = false;
                this.Size = new Size(489, 340);
            }
        }

        private void selectSavedScore_lv_DoubleClick(object sender, EventArgs e)
        {
            if(selectSavedScore_lv.SelectedItems.Count != 0 && !listNoData)
            {
                StudentListCheck _form = new StudentListCheck(readData(nameFile[nameComboBox.SelectedIndex].FullName), allScoresColumn[selectSavedScore_lv.SelectedItems[0].Index]);
                _form.Show();

            }
        }

        private void selectSavedScore_lv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
