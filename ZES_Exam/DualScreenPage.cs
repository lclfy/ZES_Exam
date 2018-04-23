using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ZES_Exam
{
    public partial class DualScreenPage : Skin_Mac
    {
        string currentQuestion = "";
        MainPage main;
        public DualScreenPage(MainPage _main, string _question = "")
        {
            main = _main;
            currentQuestion = _question;
            InitializeComponent();
        }

        private void DualScreenPage_Load(object sender, EventArgs e)
        {
            question_lbl.Text = currentQuestion;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            this.Hide();
            main.splitScreenOnWork = false;
            base.OnClosing(e);
        }
    }
}
