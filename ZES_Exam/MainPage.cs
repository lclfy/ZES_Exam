using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.HSSF.UserModel;
using System.IO;

namespace ZES_Exam
{
    public partial class MainPage : Skin_Mac
    {
        private string nameFile;
        private string paperFile;
        private int gradeColumnOfNameFile = -1;
        List<Students> allStudents;
        Paper paper;
        bool rolling = false;
        int questionID = -1;
        int studentID = -1;
        int count = 0;
        public bool splitScreenOnWork = false;
        DualScreenPage splitedScreenPage;

        public MainPage(IWorkbook _nameWorkbook, IWorkbook _paperWorkbook, string _nameFile, string _paperFile)
        {
            this.nameFile = _nameFile;
            this.paperFile = _paperFile;
            paper = getPaper(_paperWorkbook);
            allStudents = getStudents(_nameWorkbook);
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            right_btn.Enabled = false;
            wrong_btn.Enabled = false;
        }

        private Paper getPaper(IWorkbook _paperWorkbook)
        {
            Paper _paper = new Paper();
            List<Question> allQuestions = new List<Question>();
            ISheet sheet = _paperWorkbook.GetSheetAt(0);  //获取第一个工作表  
            if(sheet.GetRow(0)!= null)
            {
                if (sheet.GetRow(0).GetCell(0) != null)
                {
                    _paper.paperName = sheet.GetRow(0).GetCell(0).ToString().Trim();
                }
                else
                {
                    MessageBox.Show("试卷格式错误：无试卷标题，请联系职教科");
                }
            }
            else
            {
                MessageBox.Show("试卷格式错误：无试卷标题，请联系职教科");
            }
            for (int i = 2; i <= sheet.LastRowNum; i++)
            {
                Question _question = new Question();
                IRow row = sheet.GetRow(i);
                _question.questionID = i -1;
                string answers = "";
                for(int j = 1; j <= row.LastCellNum; j++)
                {
                    if(j == 1)
                    {
                        if (row.GetCell(0) != null)
                        {
                            _question.questionName = row.GetCell(0).ToString().Trim();
                            if (row.GetCell(1) != null)
                            {
                                _question.rightAnswer = row.GetCell(1).ToString().Trim();
                            }
                            else
                            {
                                _question.rightAnswer = "无";
                            }
                        }
                        else
                        {
                            _question.questionName = "";
                            continue;
                        }
                    }
                    else
                    {
                        if(row.GetCell(j) != null)
                        {
                            answers = answers + row.GetCell(j).ToString().Trim() + "-";
                        }
                        else
                        {
                            answers = answers + "-";
                        }
                    }
                }
                _question.answers = answers.Remove(answers.Length - 1, 1);
                allQuestions.Add(_question);
            }
            _paper.questions = allQuestions;
            return _paper;
        }

        private List<Students> getStudents(IWorkbook _nameWorkbook)
        {
            List<Students> _students = new List<Students>();
            ISheet sheet = _nameWorkbook.GetSheetAt(0);  //获取第一个工作表  
            //找到当前试卷所在的列（没有的新建）
            if(sheet.GetRow(1)!= null)
            {
                int currentPaperColumn = -1;
                IRow row = sheet.GetRow(1);
                for (int j = 0; j <= row.LastCellNum; j++)
                {
                    if(row.GetCell(j)!= null)
                    {
                        if (row.GetCell(j).ToString().Trim().Equals(paper.paperName))
                        {
                            currentPaperColumn = j;
                            break;
                        }
                    }
                    if(currentPaperColumn != -1)
                    {
                        break;
                    }
                }
                if(currentPaperColumn == -1)
                {
                    row.CreateCell(row.LastCellNum + 1).SetCellValue(paper.paperName);
                    currentPaperColumn = row.LastCellNum + 1;
                }
                gradeColumnOfNameFile = currentPaperColumn;
            }
            else
            {
                return null;
            }
            
            for(int i = 2; i <= sheet.LastRowNum; i++)
            {
                IRow row;
                if(sheet.GetRow(i)!= null)
                {
                    row = sheet.GetRow(i);
                    Students _s = new Students();
                    if(row.GetCell(0)!= null)
                    {
                        _s.name = row.GetCell(0).ToString().Trim();
                    }
                    if(row.GetCell(gradeColumnOfNameFile) != null)
                    {
                        _s.grade = row.GetCell(gradeColumnOfNameFile).ToString().Trim();
                    }
                    else
                    {
                        _s.grade = "0";
                    }
                    _students.Add(_s);
                }
                else
                {
                    continue;
                }
            }
            return _students;
        }

        private void roll_btn_Click(object sender, EventArgs e)
        {
            if (!rolling)
            {
                startRolling();
                rolling = true;
                roll_btn.Text = "结束";
            }
            else
            {
                stopRolling();
                rolling = false;
                roll_btn.Text = "开始";
            }
        }

        private void startRolling()
        {
            rollingTimer.Start();
            answer_lbl.Text = "";
            if(splitedScreenPage != null)
            {
                splitedScreenPage.answer_lbl.Text = "";
            }
            
        }

        private void stopRolling()
        {
            rollingTimer.Stop();
            if(paper.questions[questionID].answers != null)
            {
                if(paper.questions[questionID].answers.Length != 0)
                {
                    answer_lbl.Text = paper.questions[questionID].answers;
                }
                else
                {
                    answer_lbl.Text = paper.questions[questionID].rightAnswer;
                }
            }
            else
            {
                answer_lbl.Text = paper.questions[questionID].rightAnswer;
            }
        }

        private void selectStudent_btn_Click(object sender, EventArgs e)
        {
            studentTimer.Start();
        }

        private void rollingTimer_Tick(object sender, EventArgs e)
        {
            Random rd = new Random();
            questionID = rd.Next(0, paper.questions.Count);
            question_lbl.Text = paper.questions[questionID].questionName;
            if (splitedScreenPage != null)
            {
                splitedScreenPage.question_lbl.Text = paper.questions[questionID].questionName;
            }
        }

        private void studentTimer_Tick(object sender, EventArgs e)
        {
            Random rd = new Random();
            studentName_lbl.Text = allStudents[rd.Next(0, allStudents.Count)].name;
            count++;
            if(count > 10)
            {
                count = 0;
                int _counter = rd.Next(0, allStudents.Count);
                studentName_lbl.Text = allStudents[_counter].name +"-分数:" + allStudents[_counter].grade;
                studentID = _counter;
                right_btn.Enabled = true;
                wrong_btn.Enabled = true;
                studentTimer.Stop();
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            DialogResult result = MessageBox.Show("是否确认关闭？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            e.Cancel = result != DialogResult.Yes;
            if (result == DialogResult.Yes)
            {
                save();
                Application.Exit();
            }
            base.OnClosing(e);
        }

        private void save()
        {
            IWorkbook workbook = null;  //新建IWorkbook对象  
            try
            {
                FileStream fileStream = new FileStream(nameFile, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
                if (nameFile.IndexOf(".xlsx") > 0) // 2007版本  
                {
                    try
                    {
                        workbook = new XSSFWorkbook(fileStream);  //xlsx数据读入workbook  
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("文件出错：" + e.ToString().Split('。')[0] + "\n" + nameFile);
                    }
                }
                else if (nameFile.IndexOf(".xls") > 0) // 2003版本  
                {
                    try
                    {
                        workbook = new HSSFWorkbook(fileStream);  //xls数据读入workbook  
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("访问文件出错：\n" + e.ToString().Split('。')[0]);
                    }
                }
                ISheet sheet1 = workbook.GetSheetAt(0);
                for(int i = 1; i <= sheet1.LastRowNum; i++)
                {
                    IRow row = sheet1.GetRow(i);
                    if(i == 1)
                    {
                        if (row.GetCell(gradeColumnOfNameFile) == null)
                        {
                            row.CreateCell(gradeColumnOfNameFile).SetCellValue(paper.paperName);
                        }
                    }
                    else
                    {
                        if (row.GetCell(gradeColumnOfNameFile) == null)
                        {
                            row.CreateCell(gradeColumnOfNameFile).SetCellValue(allStudents[i - 2].grade);
                        }
                        else
                        {
                            row.GetCell(gradeColumnOfNameFile).SetCellValue(allStudents[i - 2].grade);
                        }
                    }
                }
                FileStream fs1 = File.OpenWrite(nameFile);
                workbook.Write(fs1);
                fileStream.Close();
                fs1.Close();
                workbook.Close();
            }
            catch (IOException e)
            {
                MessageBox.Show("访问文件出错：\n" + e.ToString().Split('。')[0]);
            }
        }

        private void right_btn_Click(object sender, EventArgs e)
        {
            allStudents[studentID].grade = allStudents[studentID].grade + "√";
        }

        private void wrong_btn_Click(object sender, EventArgs e)
        {
            allStudents[studentID].grade = allStudents[studentID].grade + "×";
        }

        private void splitScreen_btn_Click(object sender, EventArgs e)
        {
            if (!splitScreenOnWork)
            {
                string currentQuestion = "";
                if(questionID != -1)
                {
                    currentQuestion = paper.questions[questionID].questionName;
                }
                splitedScreenPage = new DualScreenPage(this, currentQuestion);
                splitedScreenPage.Show();
                splitScreenOnWork = true;
            }
            else
            {
                splitedScreenPage.Hide();
                splitScreenOnWork = false;
            }
        }

        //显示分屏答案
        private void showRightAnswer_btn_Click(object sender, EventArgs e)
        {
            if (splitedScreenPage != null)
            {
                splitedScreenPage.answer_lbl.Text = paper.questions[questionID].rightAnswer;
            }
        }
    }
}
