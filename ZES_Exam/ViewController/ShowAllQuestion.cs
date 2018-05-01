using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CCWin;

namespace ZES_Exam
{
    public partial class ShowAllQuestion : Skin_Mac
    {
        public Paper paper;
        List<Question> searchedQuestions = new List<Question>();
        public bool searched = false;
        public MainPage mainPage = null;

        public ShowAllQuestion(Paper _paper, MainPage _mainPage)
        {
            paper = _paper;
            mainPage = _mainPage;
            InitializeComponent();
        }

        private void ShowAllQuestion_Load(object sender, EventArgs e)
        {
            updateList();
        }

        private void searchList()
        {
            if(search_tb.Text.Length == 0)
            {
                updateList();
                searched = false;
            }
            else
            {
                questions_lv.Items.Clear();
                foreach (Question _q in paper.questions)
                {
                    Question _tempQ = new Question();
                    if (_q.questionName.Contains(search_tb.Text.ToString().Trim()))
                    {
                        _tempQ = _q;
                        searchedQuestions.Add(_tempQ);
                        ListViewItem lvi = new ListViewItem(_q.questionName);
                        lvi.SubItems.Add(_q.questionCategory);
                        questions_lv.Items.Add(lvi);
                        searched = true;
                    }
                }
                questions_lv.Update();
            }

        }

        private void updateList()
        {
            questions_lv.Items.Clear();
            foreach(Question _q in paper.questions)
            {
                ListViewItem lvi = new ListViewItem(_q.questionName);
                lvi.SubItems.Add(_q.questionCategory);
                questions_lv.Items.Add(lvi);
            }
            questions_lv.Update();
        }

        private void returnData()
        {
            if (searched)
            {
                mainPage.getQuestion(searchedQuestions[questions_lv.SelectedItems[0].Index]);
            }
            else
            {
                mainPage.getQuestion(paper.questions[questions_lv.SelectedItems[0].Index]);
            }
                
        }


        private void questions_lv_DoubleClick(object sender, EventArgs e)
        {
            if(questions_lv.SelectedItems.Count != 0)
            {
                returnData();
            }
        }

        private void questions_lv_Click(object sender, EventArgs e)
        {
            if (questions_lv.SelectedItems.Count != 0)
            {
                returnData();
            }
        }

        private void search_tb_TextChanged(object sender, EventArgs e)
        {
            searchList();
        }
    }
}
