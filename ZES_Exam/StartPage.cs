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

namespace ZES_Exam
{
    public partial class StartPage : Skin_Mac
    {
        List<FileInfo> nameFile = new List<FileInfo>();
        List<FileInfo> paperFile = new List<FileInfo>();
        public StartPage()
        {
            InitializeComponent();
        }

        private void StartPage_Load(object sender, EventArgs e)
        {
            LookFile(0);
            LookFile(1);
            checkStartButton();
            checkName_btn.Enabled = false;
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
            IWorkbook nameWorkbook = readData(nameFile[nameComboBox.SelectedIndex].FullName);
            StudentListCheck form = new StudentListCheck(nameWorkbook);
            form.Show();
        }

        private void checkStartButton()
        {
            if (nameComboBox.Text.Length == 0 ||
            examPaperComboBox.Text.Length == 0)
            {
                startButton.Enabled = false;
            }
            else
            {
                startButton.Enabled = true;
            }
            if(nameComboBox.Text.Length != 0)
            {
                checkName_btn.Enabled = true;
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
            IWorkbook nameWorkbook = readData(nameFile[nameComboBox.SelectedIndex].FullName);
            IWorkbook paperWorkbook = readData(paperFile[examPaperComboBox.SelectedIndex].FullName);
            if(nameWorkbook != null &&
                paperWorkbook != null)
            {
                MainPage page = new MainPage(nameWorkbook,paperWorkbook, nameFile[nameComboBox.SelectedIndex].FullName, paperFile[examPaperComboBox.SelectedIndex].FullName);
                page.Show();
                this.Hide();
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


    }
}
