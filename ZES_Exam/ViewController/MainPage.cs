﻿using CCWin;
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
using ZES_Exam.ViewController;
using ZES_Exam.Model;

namespace ZES_Exam
{
    public partial class MainPage : Skin_Mac
    {
        private string nameFile;
        private string paperFile;
        private string logFile;
        private int gradeColumnOfNameFile = -1;
        List<Students> allStudents;
        Paper paper;
        List<DataLogModel> allTestLogs = new List<DataLogModel>();
        public SettingModel settingModel;
        public List<string> allChosenCategories;
        IWorkbook logWorkbook;
        bool rolling = false;
        int questionID = -1;
        int studentID = -1;
        int count = 0;
        string className = "";
        public bool onlyOneAnswer = false;
        public bool firstTimeChecked = false;
        public bool splitScreenOnWork = false;
        public bool showOrHideAnswer = false;
        public bool getAnyException = false;
        DualScreenPage splitedScreenPage;
        StartPage startPage;
        //列表排序用
        private mySorter sorter;


        public MainPage(StartPage _startPage, IWorkbook _nameWorkbook, IWorkbook _paperWorkbook,IWorkbook _logWorkbook, string _nameFile, string _paperFile, string _logFile)
        {
            this.nameFile = _nameFile;
            this.paperFile = _paperFile;
            this.logFile = _logFile;
            this.startPage = _startPage;
            logWorkbook = _logWorkbook;
            paper = getPaper(_paperWorkbook);
            allStudents = getStudents(_nameWorkbook);
            sorter = new mySorter();

            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            right_btn.Enabled = false;
            wrong_btn.Enabled = false;
            sorter.SortColumn = 1;
            //为ListViewItemSorter指定排序类
            this.name_lv.ListViewItemSorter = sorter;
            sorter.SortOrder = SortOrder.Descending;
            updateListAndSettings();
        }


        private Paper getPaper(IWorkbook _paperWorkbook)
        {
            Paper _paper = new Paper();
            List<Question> allQuestions = new List<Question>();
            ISheet sheet = _paperWorkbook.GetSheetAt(0);  //获取第一个工作表  
            try
            {
                if (sheet.GetRow(0) != null)
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
                    _question.questionID = i - 1;
                    string answers = "";
                    for (int j = 2; j <= row.LastCellNum; j++)
                    {
                        if (j == 2)
                        {
                            if (row.GetCell(0) != null)
                            {
                                _question.questionCategory = row.GetCell(0).ToString().Replace("，", ",").Trim();
                            }
                            else
                            {
                                _question.questionCategory = "无类别";
                            }
                            if (row.GetCell(1) != null)
                            {
                                _question.questionName = row.GetCell(1).ToString().Trim();
                                if (row.GetCell(2) != null)
                                {
                                    _question.rightAnswer = row.GetCell(2).ToString().Trim();
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
                            if (row.GetCell(j) != null)
                            {
                                answers = answers + row.GetCell(j).ToString().Trim() + "|";
                            }
                            else
                            {
                                answers = answers + "|";
                            }
                        }
                    }
                    _question.answers = answers.Remove(answers.Length - 1, 1);
                    allQuestions.Add(_question);
                }
                _paper.questions = allQuestions;
                questionCategoryCheck(allQuestions);
                return _paper;
            }
            catch (Exception e)
            {
                if (allQuestions.Count == 0)
                {
                    MessageBox.Show("题库格式不正确致使读取题库失败，请检查题库文件:\n" + paperFile, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    getAnyException = true;
                }
                else
                {
                    MessageBox.Show("题库格式不正确致使读取题库失败，下列为读取样本，请检查错误\n"
                    + "题库文件：" + paperFile + "\n题目分类(表格第一列)：" + allQuestions[0].questionCategory + "\n题目名称(第二列)：" + allQuestions[0].questionName + "\n正确答案(第三列)：" + allQuestions[0].rightAnswer, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    getAnyException = true;
                }
            }
            return _paper;
        }

        //找出所有的分类
        private void questionCategoryCheck(List<Question> _questions)
        {
            List<QuestionCategory> _category = new List<QuestionCategory>();
            foreach(Question q in _questions)
            { 
                if(q.questionCategory == null)
                {
                    continue;
                }
                for (int i = 0; i < q.questionCategory.Split(',').Length; i++)
                {
                    bool hasGotIt = false;
                    foreach (QuestionCategory qc in _category)
                    {
                        if (qc.categoryName.Equals(q.questionCategory.Split(',')[i]))
                        {
                            hasGotIt = true;
                        }
                        if (hasGotIt)
                        {
                            break;
                        }
                    }
                    if (!hasGotIt)
                    {
                        QuestionCategory _tempQC = new QuestionCategory();
                        _tempQC.categoryName = q.questionCategory.Split(',')[i].ToString();
                        _tempQC.chosen = true;
                        _category.Add(_tempQC);
                    }
                }
            }
            if(settingModel == null)
            {
                settingModel = new SettingModel();
            }
            settingModel.questionCategory = _category;
            List<string> _tempCC = new List<string>();
            foreach(QuestionCategory _qc in _category)
            {
                _tempCC.Add(_qc.categoryName);
            }
            allChosenCategories = _tempCC;
        }

        private List<Students> getStudents(IWorkbook _nameWorkbook)
        {
            List<Students> _students = new List<Students>();
            ISheet sheet = _nameWorkbook.GetSheetAt(0);  //获取第一个工作表  
            //标题
            try
            {
                if (sheet.GetRow(0) != null)
                {
                    if (sheet.GetRow(0).GetCell(0) != null)
                    {
                        className = sheet.GetRow(0).GetCell(0).ToString().Trim();
                    }
                }
                //找到当前试卷所在的列（没有的新建）
                if (sheet.GetRow(1) != null)
                {
                    int currentPaperColumn = -1;
                    IRow row = sheet.GetRow(1);
                    for (int j = 0; j <= row.LastCellNum; j++)
                    {
                        if (row.GetCell(j) != null)
                        {
                            if (row.GetCell(j).ToString().Trim().Equals(paper.paperName))
                            {
                                currentPaperColumn = j;
                                break;
                            }
                        }
                        if (currentPaperColumn != -1)
                        {
                            break;
                        }
                    }
                    if (currentPaperColumn == -1)
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

                for (int i = 2; i <= sheet.LastRowNum; i++)
                {
                    IRow row;
                    if (sheet.GetRow(i) != null)
                    {
                        row = sheet.GetRow(i);
                        Students _s = new Students();
                        if (row.GetCell(0) != null)
                        {
                            _s.name = row.GetCell(0).ToString().Trim();
                        }
                        if (row.GetCell(gradeColumnOfNameFile) != null)
                        {
                            _s.grade = row.GetCell(gradeColumnOfNameFile).ToString().Trim();
                        }
                        else
                        {
                            _s.grade = "";
                        }
                        _students.Add(_s);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            catch (Exception e)
            {
                if (_students.Count == 0)
                {
                    MessageBox.Show("名单格式不正确致使读取名单失败，请检查名单文件:\n" + nameFile, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    getAnyException = true;
                }
                else
                {
                    MessageBox.Show("名单格式不正确致使读取名单失败，下列为读取样本，请检查错误\n"+
                    "名单文件："+nameFile + "\n学生姓名(表格第一列)：" + _students[0].name + "\n当前试卷成绩：" + _students[0].grade , "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    getAnyException = true;
                }
            }  
            return _students;
        }

        private void roll_btn_Click(object sender, EventArgs e)
        {
            if(settingModel.selectQuestionMode == 0)
            {
                if (!rolling)
                {
                    startRolling(0);
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
            else
            {
                startRolling(1);
            }
         
        }

        private void startRolling(int mode)
        {
            if(mode == 0)
            {
                rollingTimer.Start();
            }
            else
            {
                bool hasGotIt = false;
                while (!hasGotIt)
                {
                    Random rd = new Random();
                    questionID = rd.Next(0, paper.questions.Count);
                    string[] questionCategories = paper.questions[questionID].questionCategory.Split(',');
                    foreach (String _category in allChosenCategories)
                    {//找到一个就算
                        for (int i = 0; i < questionCategories.Length; i++)
                        {
                            if (_category.Equals(questionCategories[i]))
                            {
                                hasGotIt = true;
                            }
                            if (hasGotIt)
                            {
                                break;
                            }
                        }
                        if (hasGotIt)
                        {
                            break;
                        }
                    }
                }
                question_lbl.Text = splitString(paper.questions[questionID].questionName, 25);
                if (splitedScreenPage != null)
                {
                    splitedScreenPage.question_lbl.Text = splitString(paper.questions[questionID].questionName, 25);
                }
            }
            answer_lbl.Text = "";
            showOrHideAnswer = false;
            showRightAnswer_btn.Text = "显示答案";
            showRightAnswer_btn.Enabled = false;
            if (splitedScreenPage != null)
            {
                splitedScreenPage.answer_lbl.Text = "";
            }
            if(mode == 1)
            {
                stopRolling();
                roll_btn.Text = "抽题";
            }
            
        }

        private void stopRolling()
        {
            if (questionID == -1)
            {
                return;
            }
            rollingTimer.Stop();
            showRightAnswer_btn.Enabled = true;
            if (paper.questions[questionID].answers != null)
            {
                if(paper.questions[questionID].answers.Length != 0)
                {
                    onlyOneAnswer = false;
                    string[] answers = paper.questions[questionID].answers.Trim().Replace(" ","").Split('|');
                    string answerString = "";
                    for(int i = 0; i < answers.Length - 1; i++)
                    {
                        switch (i)
                        {
                            case 0:
                                {
                                    answerString = answerString+ "A. " + answers[i] + "\n";
                                    break;
                                }
                            case 1:
                                {
                                    answerString = answerString + "B. " + answers[i] + "\n";
                                    break;
                                }
                            case 2:
                                {
                                    answerString = answerString + "C. " + answers[i] + "\n";
                                    break;
                                }
                            case 3:
                                {
                                    answerString = answerString + "D. " + answers[i] + "\n";
                                    break;
                                }
                            case 4:
                                {
                                    answerString = answerString + "E. " + answers[i] + "\n";
                                    break;
                                }
                            case 5:
                                {
                                    answerString = answerString + "F. " + answers[i] + "\n";
                                    break;
                                }
                        }
                        
                    }
                    answer_lbl.Text = answerString;
                    if (splitScreenOnWork)
                    {
                        splitedScreenPage.answer_lbl.Text = answerString;
                        //分屏时主屏直接显示答案
                        answer_lbl.Text = answer_lbl.Text + "\n" + "正确答案：" + paper.questions[questionID].rightAnswer;
                    }
                }
                else
                {
                    onlyOneAnswer = true;
                    if (splitScreenOnWork)
                    {
                        answer_lbl.Text = splitString(paper.questions[questionID].rightAnswer, 25);
                    }
                    else
                    {
                        answer_lbl.Text = "请作答";
                    }
                }
            }
            else
            {
                onlyOneAnswer = true;
                if (splitScreenOnWork)
                {
                    answer_lbl.Text = splitString(paper.questions[questionID].rightAnswer,25);
                }
                else
                {
                    answer_lbl.Text = "请作答";
                }
            }
        }

        public void updateListAndSettings()
        {
            name_lv.Items.Clear();
            name_lv.BeginUpdate();
            updateChosenCategories();
            foreach (Students _s in allStudents)
            {
                ListViewItem _lvi = new ListViewItem(_s.name);
                if (!settingModel.rankModeEnabled)
                {
                    _lvi.SubItems.Add(_s.grade);
                }
                else
                {//比较乱…懒得改了
                    if (settingModel.hasNewOriginalScore || settingModel.clearData)
                    {
                        _lvi.SubItems.Add(settingModel.originalScore.ToString());
                        initOriginalScore();
                    }
                    else
                    {
                        _lvi.SubItems.Add(_s.rankGrade.ToString());
                    }
                }
                name_lv.Items.Add(_lvi);
            }
            if (settingModel.rankModeEnabled)
            {
                name_lv.Sort();
            }
            name_lv.EndUpdate();
        }

        private void initOriginalScore()
        {
            foreach(Students _s in allStudents)
            {
                _s.rankGrade = settingModel.originalScore;
            }
            settingModel.hasNewOriginalScore = false;
            settingModel.clearData = false;
        }

        private void updateChosenCategories()
        {
            List<string> tempCC = new List<string>();
            foreach(QuestionCategory _qc in settingModel.questionCategory)
            {
                if(_qc.chosen)
                {
                    tempCC.Add(_qc.categoryName);
                }
            }
            allChosenCategories = tempCC;
        }

        private void selectStudent_btn_Click(object sender, EventArgs e)
        {
            wrong_btn.Enabled = false;
            right_btn.Enabled = false;
            selectStudent_btn.Enabled = false;
            studentTimer.Start();
        }

        private void rollingTimer_Tick(object sender, EventArgs e)
        {
            bool hasGotIt = false;
            while (!hasGotIt)
            {
                Random rd = new Random();
                questionID = rd.Next(0, paper.questions.Count);
                string[] questionCategories = paper.questions[questionID].questionCategory.Split(',');
                foreach (String _category in allChosenCategories)
                {//找到一个就算
                    for (int i = 0; i < questionCategories.Length; i++)
                    {
                        if (_category.Equals(questionCategories[i]))
                        {
                            hasGotIt = true;
                        }
                        if (hasGotIt)
                        {
                            break;
                        }
                    }
                    if (hasGotIt)
                    {
                        break;
                    }
                }
            }
            question_lbl.Text = splitString(paper.questions[questionID].questionName, 25);
            if (splitedScreenPage != null)
            {
                splitedScreenPage.question_lbl.Text = splitString(paper.questions[questionID].questionName,25);
            }
        }

        //分割过长字符串
        private string splitString(string _target, int numOfSplit)
        {
            string splitedString = "";
            for(int i = 0; i <= (_target.Length/numOfSplit); i++)
            {
                if(_target.Length - (i * numOfSplit) < numOfSplit)
                {
                    splitedString = splitedString + _target.Substring(i * numOfSplit, _target.Length - (i * numOfSplit)) + "\n";
                }
                else
                {
                    splitedString = splitedString + _target.Substring(i * numOfSplit, numOfSplit) + "\n";
                }
            }
            return splitedString;
        }

        private void studentTimer_Tick(object sender, EventArgs e)
        {
            if(allStudents.Count == 0)
            {
                studentTimer.Stop();
                return;
            }
            Random rd = new Random();
            studentName_lbl.Text = allStudents[rd.Next(0, allStudents.Count)].name;
            count++;
            if(count > 10)
            {
                count = 0;
                int _counter = rd.Next(0, allStudents.Count);
                //studentName_lbl.Text = allStudents[_counter].name +"-分数:" + allStudents[_counter].grade;
                studentName_lbl.Text = allStudents[_counter].name;
                studentID = _counter;
                right_btn.Enabled = true;
                wrong_btn.Enabled = true;
                studentTimer.Stop();
                selectStudent_btn.Enabled = true;
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            DialogResult result = MessageBox.Show("是否确认关闭？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            e.Cancel = result != DialogResult.Yes;
            if (result == DialogResult.Yes)
            {
                save();
                Application.Exit();
            }
            base.OnClosing(e);
        }

        //保存
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

            //保存记录
            ISheet sheet = logWorkbook.GetSheetAt(0);
            int lastRow = sheet.LastRowNum;
            for (int i = lastRow + 1; i < lastRow + allTestLogs.Count; i++)
            {
                IRow row = sheet.CreateRow(i);
                DataLogModel _model = allTestLogs[i - lastRow];
                    for (int j = 0; j < 9; j++)
                    {
                        if (row.GetCell(j) == null)
                        {
                            row.CreateCell(j);
                        }
                        switch (j)
                        {
                            case 0:
                                row.GetCell(j).SetCellValue(_model.time);
                                break;
                            case 1:
                                if(_model.rightOrWrong)
                                {
                                    row.GetCell(j).SetCellValue("√");
                                }
                                else
                                {
                                    row.GetCell(j).SetCellValue("×");
                                }
                                break;
                            case 2:
                                row.GetCell(j).SetCellValue(_model.studentName);
                                break;
                            case 3:
                                row.GetCell(j).SetCellValue(_model.studentFile);
                                break;
                            case 4:
                                row.GetCell(j).SetCellValue(_model.className);
                                break;
                            case 5:
                                row.GetCell(j).SetCellValue(_model.testName);
                                break;
                            case 6:
                                row.GetCell(j).SetCellValue(_model.testFile);
                                break;
                            case 7:
                                row.GetCell(j).SetCellValue(_model.questionName);
                                break;
                            case 8:
                                row.GetCell(j).SetCellValue(_model.rightAnswer);
                                break;
                        }
                    }

            }
            try
            {
                FileStream fs = File.Create(logFile);
                //向excel文件中写入数据并保保存
                logWorkbook.Write(fs);
                fs.Close();
            }catch(Exception e)
            {
                MessageBox.Show(e.ToString().Split('。')[1]);
            }


        }

        private void right_btn_Click(object sender, EventArgs e)
        {
            if(questionID < 0)
            {
                right_lbl.Visible = true;
                right_lbl.Text = "没有题目";
                rightTimer.Start();
                return;
            }
            else
            {
                if (settingModel.rankModeEnabled)
                {
                    right_lbl.Text = "+"+settingModel.singleQuestionScore.ToString() + "分";
                    allStudents[studentID].rankGrade = allStudents[studentID].rankGrade + settingModel.singleQuestionScore;
                    right_lbl.Visible = true;
                    logTestData(true);
                    rightTimer.Start();
                    updateListAndSettings();
                }
                else
                {
                    right_lbl.Text = "提交成功";
                    allStudents[studentID].grade = allStudents[studentID].grade + "√";
                    right_lbl.Visible = true;
                    logTestData(true);
                    rightTimer.Start();
                    updateListAndSettings();
                }

            }

        }

        private void wrong_btn_Click(object sender, EventArgs e)
        {
            if (questionID < 0)
            {
                wrong_lbl.Visible = true;
                wrong_lbl.Text = "没有题目";
                wrongTimer.Start();
                return;
            }
            else
            {
                if (settingModel.rankModeEnabled)
                {
                    if (settingModel.scoreNoDeduction)
                    {//答错不扣分
                        wrong_lbl.Text = "提交成功";
                    }
                    else
                    {
                        wrong_lbl.Text = "-" + settingModel.singleQuestionScore.ToString() + "分";
                        allStudents[studentID].rankGrade = allStudents[studentID].rankGrade - settingModel.singleQuestionScore;
                    }
                    wrong_lbl.Visible = true;
                    logTestData(false);
                    wrongTimer.Start();
                    updateListAndSettings();
                }
                else
                {
                    wrong_lbl.Text = "提交成功";
                    wrongTimer.Start();
                    wrong_lbl.Visible = true;
                    logTestData(false);
                    allStudents[studentID].grade = allStudents[studentID].grade + "×";
                    updateListAndSettings();
                }
            }

        }

        private void splitScreen_btn_Click(object sender, EventArgs e)
        {
            if (!splitScreenOnWork)
            {
                showOrHideAnswer = false;
                showRightAnswer();
                string currentQuestion = "";
                if(questionID != -1)
                {
                    currentQuestion = splitString(paper.questions[questionID].questionName, 25);
                }
                splitedScreenPage = new DualScreenPage(this, currentQuestion);
                //splitedScreenPage.answer_lbl.Text = answer_lbl.Text;
                splitedScreenPage.Show();
                splitScreenOnWork = true;
                showOrHideAnswer = true;
                showRightAnswer();
            }
            else
            {
                showOrHideAnswer = true;
                showRightAnswer_btn.Text = "隐藏答案";
                splitedScreenPage.Hide();
                splitScreenOnWork = false;
            }
        }
        //显示答案
        private void showRightAnswer()
        {
            if(questionID == -1)
            {
                return;
            }
            if (!showOrHideAnswer)
            {
                if (splitScreenOnWork)
                {
                    if (onlyOneAnswer)
                    {
                        splitedScreenPage.answer_lbl.Text = splitString(paper.questions[questionID].rightAnswer, 25);
                    }
                    else
                    {
                        if (!splitedScreenPage.answer_lbl.Text.Contains("正确答案："))
                        {
                            splitedScreenPage.answer_lbl.Text = splitedScreenPage.answer_lbl.Text + "\n" + "正确答案：" + paper.questions[questionID].rightAnswer;
                        }
                    }
                }
                else
                {//单屏
                    {
                        if (onlyOneAnswer)
                        {
                            answer_lbl.Text = splitString(paper.questions[questionID].rightAnswer, 25);
                        }
                        else
                        {
                            if (!answer_lbl.Text.Contains("正确答案："))
                            {
                                answer_lbl.Text = answer_lbl.Text + "\n" + "正确答案：" + paper.questions[questionID].rightAnswer;
                            }
                        }

                    }
                }
                showOrHideAnswer = true;
                showRightAnswer_btn.Text = "隐藏答案";
            }
            else
            {
                if (splitScreenOnWork)
                {
                    if (onlyOneAnswer)
                    {
                        splitedScreenPage.answer_lbl.Text = "请作答";
                    }
                    else
                    {
                        stopRolling();
                    }
                }
                else
                {//单屏
                    {
                        if (onlyOneAnswer)
                        {
                            answer_lbl.Text = "请作答";
                        }
                        else
                        {
                            stopRolling();
                        }

                    }
                }
                showOrHideAnswer = false;
                showRightAnswer_btn.Text = "显示答案";
            }
        }

        //保存时用于记录答案和正确答案
        private string getRightAnswer()
        {
            string rightAnswer = "";
            if (questionID == -1)
            {
                return rightAnswer;
            }
            if (paper.questions[questionID].answers != null)
            {
                if (paper.questions[questionID].answers.Length != 0)
                {
                    string[] answers = paper.questions[questionID].answers.Trim().Replace(" ", "").Split('|');
                    string answerString = "";
                    for (int i = 0; i < answers.Length - 1; i++)
                    {
                        switch (i)
                        {
                            case 0:
                                {
                                    answerString = answerString + "A. " + answers[i] + "\n";
                                    break;
                                }
                            case 1:
                                {
                                    answerString = answerString + "B. " + answers[i] + "\n";
                                    break;
                                }
                            case 2:
                                {
                                    answerString = answerString + "C. " + answers[i] + "\n";
                                    break;
                                }
                            case 3:
                                {
                                    answerString = answerString + "D. " + answers[i] + "\n";
                                    break;
                                }
                            case 4:
                                {
                                    answerString = answerString + "E. " + answers[i] + "\n";
                                    break;
                                }
                            case 5:
                                {
                                    answerString = answerString + "F. " + answers[i] + "\n";
                                    break;
                                }
                        }

                    }
                    rightAnswer = answerString + "\n" + "正确答案：" + paper.questions[questionID].rightAnswer;
                }
                else
                {
                    rightAnswer = paper.questions[questionID].rightAnswer;
                }
            }
            else
            {
                rightAnswer = paper.questions[questionID].rightAnswer;
            }
            return rightAnswer;
        }

        private void showRightAnswer_btn_Click(object sender, EventArgs e)
        {
            showRightAnswer();
        }

        private void question_lbl_Click(object sender, EventArgs e)
        {

        }

        private void name_lv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(name_lv.SelectedItems.Count != 0)
            {
                studentName_lbl.Text = name_lv.SelectedItems[0].SubItems[0].Text.ToString();
                studentID = -1;
                for(int i = 0;i < allStudents.Count; i++)
                {
                    if (allStudents[i].name.Equals(studentName_lbl.Text.ToString().Trim()))
                    {
                        studentID = i;
                    }
                }
                if(studentID == -1)
                {
                    int ij = 0;
                }
                right_btn.Enabled = true;
                wrong_btn.Enabled = true;
            }
        }

        //反馈提示(1s)
        private void tipTimer_Tick(object sender, EventArgs e)
        {
            if (right_lbl.Visible == true)
            {
                right_lbl.Visible = false;
                rightTimer.Stop();
            }
            else
            {
                right_lbl.Visible = true;
            }
        }

        private void wrongTimer_Tick(object sender, EventArgs e)
        {
            if (wrong_lbl.Visible == true)
            {
                wrong_lbl.Visible = false;
                wrongTimer.Stop();
            }
            else
            {
                wrong_lbl.Visible = true;
            }
        }

        //每次答题自动记录
        private void logTestData(bool rightOrWrong)
        {
            if(studentID != -1 && questionID != -1)
            {
                DataLogModel _model = new DataLogModel();
                _model.rightOrWrong = rightOrWrong;
                _model.time = DateTime.Now.ToString("yyyyMMdd-hh:mm");
                _model.studentName = allStudents[studentID].name;
                _model.studentFile = nameFile.Split('\\')[nameFile.Split('\\').Length - 1];
                _model.className = className;
                _model.testName = paper.paperName;
                _model.testFile = paperFile.Split('\\')[nameFile.Split('\\').Length - 1];
                _model.questionName = paper.questions[questionID].questionName;
                _model.rightAnswer = getRightAnswer();
                allTestLogs.Add(_model);
            }
        }

        private void rankMode_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (rankMode_cb.Checked)
            {//进入
                if (!firstTimeChecked)
                {
                    if (settingModel == null)
                    {
                        settingModel = new SettingModel();
                    }
                    firstTimeChecked = true;
                    settingModel.rankModeEnabled = true;
                    Settings _dialog = new Settings(settingModel, this);
                    _dialog.Show();
                }
                else
                {
                    settingModel.rankModeEnabled = true;
                }
            }
            else
            {//退出
                settingModel.rankModeEnabled = false;
            }
            updateListAndSettings();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否确定返回选择/答题界面？\n答题信息将会自动保存", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                save();
                this.Hide();
                startPage.Show();
            }
        }

        private void setting_btn_Click(object sender, EventArgs e)
        {
            if (!firstTimeChecked)
            {
                firstTimeChecked = true;
            }
            if (settingModel == null)
            {
                settingModel = new SettingModel();
            }
            Settings _dialog = new Settings(settingModel,this);
            _dialog.Show();
        }
    }
}
