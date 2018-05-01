using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CCWin;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.HSSF.UserModel;
using ZES_Exam.Model;

namespace ZES_Exam.ViewController
{
    public partial class Settings : Skin_Mac
    {
        public SettingModel model;
        public int questionMode = 0;
        public MainPage mainPage = null;
        public bool chosenAll = true;
        public int theOriginalScore;
        public bool hasNewOriginalScore = false;
        public Settings(SettingModel _model,MainPage _main)
        {
            mainPage = _main;
            model = _model;
            theOriginalScore = model.originalScore;
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void RankSettings_Load(object sender, EventArgs e)
        {
            //启用计分
            if (model.rankModeEnabled)
            {
                startCountingScore_ckb.Checked = true;
            }
            else
            {
                startCountingScore_ckb.Checked = false;
            }
            //初始分数
            originalScore_tb.Text = model.originalScore.ToString();
            //单题分数
            if(model.singleQuestionScore == 0)
            {
                singleQuestionScore_tb.Text = "10";
            }
            else
            {
                singleQuestionScore_tb.Text = model.singleQuestionScore.ToString();
            }
            //答错了不扣分选项
            if (model.scoreNoDeduction)
            {//不扣分
                scoreDeduction_ckb.Checked = true;
            }
            else
            {
                scoreDeduction_ckb.Checked = false;
            }
            //倒计时
            timer_tb.Text = model.countingTime.ToString();
            questionModeChosen(model.selectQuestionMode);
            //类别
            foreach(QuestionCategory _qc in model.questionCategory)
            {
                category_clb.Items.Add(_qc.categoryName,_qc.chosen);
            }
            
        }

        //二选一菜单
        private void questionModeChosen(int _index)
        {
            if(_index == 0)
            {
                question_0.ForeColor = Color.White;
                question_0.BaseColor = Color.DodgerBlue;
                question_1.ForeColor = Color.DodgerBlue;
                question_1.BaseColor = Color.White;
                questionMode = 0;

            }
            else if(_index == 1)
            {
                question_1.ForeColor = Color.White;
                question_1.BaseColor = Color.DodgerBlue;
                question_0.ForeColor = Color.DodgerBlue;
                question_0.BaseColor = Color.White;
                questionMode = 1;
            }
        }

        private void question_0_Click(object sender, EventArgs e)
        {
            questionModeChosen(0);
        }

        private void question_1_Click(object sender, EventArgs e)
        {
            questionModeChosen(1);
        }

        private void skinGroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void skinLabel6_Click(object sender, EventArgs e)
        {

        }

        //保存
        private void save_btn_Click(object sender, EventArgs e)
        {


        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (hasNewOriginalScore)
            {
                DialogResult result = MessageBox.Show("修改初始分数会重置所有人的分数至初始值，是否继续？点击“否”将恢复初始分数至原数值并保存。", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                e.Cancel = result != DialogResult.Yes;
                if (result == DialogResult.Yes)
                {
                    save();
                    hasNewOriginalScore = false;
                }
                else
                {
                    originalScore_tb.Text = theOriginalScore.ToString();
                    save();
                }
            }
            else
            {
                save();
            }
            
            base.OnClosing(e);
        }

        private void save()
        {
            model.hasNewOriginalScore = hasNewOriginalScore;
            if (singleQuestionScore_tb.Text.ToString().Length == 0)
            {
                singleQuestionScore_tb.Text = "0";
            }
            if (timer_tb.Text.ToString().Length == 0)
            {
                timer_tb.Text = "0";
            }
            if (originalScore_tb.Text.ToString().Length == 0)
            {
                originalScore_tb.Text = "0";
            }
            try
            {
                if (startCountingScore_ckb.Checked)
                {
                    mainPage.rankMode_cb.Checked = true;
                    model.rankModeEnabled = true;
                }
                else
                {
                    mainPage.rankMode_cb.Checked = false;
                    model.rankModeEnabled = false;
                }
                model.originalScore = int.Parse(originalScore_tb.Text.ToString());
                model.singleQuestionScore = int.Parse(singleQuestionScore_tb.Text);
                if (scoreDeduction_ckb.Checked)
                {//不扣分
                    model.scoreNoDeduction = true;
                }
                else
                {
                    model.scoreNoDeduction = false;
                }
                int count = 0;
                for (int i = 0; i < category_clb.Items.Count; i++)
                {
                    if (category_clb.GetItemChecked(i))
                    {
                        count++;
                        model.questionCategory[i].chosen = true;
                    }
                    else
                    {
                        model.questionCategory[i].chosen = false;
                    }
                }
                if(count == 0)
                {
                    bool hasGotIt = false;
                    for (int i = 0; i < category_clb.Items.Count; i++)
                    {
                        if (category_clb.Items[i].ToString().Contains("无类别"))
                        {
                            model.questionCategory[i].chosen = true;
                            hasGotIt = true;
                        }
                        if (hasGotIt)
                        {
                            break;
                        }
                    }
                    if (!hasGotIt)
                    {
                        model.questionCategory[0].chosen = true;
                        MessageBox.Show("未选择任何类别，已自动选择第一项","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
                model.countingTime = int.Parse(timer_tb.Text.ToString());
                if(model.countingTime > 0)
                {
                    model.timerStarted = true;
                }
                else
                {
                    model.timerStarted = false;
                }
                model.selectQuestionMode = questionMode;
                mainPage.settingModel = model;
                mainPage.updateListAndSettings();
            }
            catch (Exception _e)
            {
                MessageBox.Show("发生保存错误：" + _e.ToString());
            }
        }

        private void originalScore_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果输入的不是数字键，也不是回车键、Backspace键，则取消该输入
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void singleQuestionScore_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果输入的不是数字键，也不是回车键、Backspace键，则取消该输入
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void timer_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果输入的不是数字键，也不是回车键、Backspace键，则取消该输入
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void singleQuestionScore_tb_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void timer_tb_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void originalScore_tb_TextChanged(object sender, EventArgs e)
        {
            int _originalScore = -1;
            int.TryParse(originalScore_tb.Text.ToString(), out _originalScore);
            if (_originalScore != theOriginalScore)
            {
                hasNewOriginalScore = true;
            }
            else
            {
                hasNewOriginalScore = false;
            }
        }

        private void startCountingScore_ckb_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void scoreDeduction_ckb_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkAll_btn_Click(object sender, EventArgs e)
        {
            if (chosenAll)
            {//全部清除
                for (int i = 0; i < category_clb.Items.Count; i++)
                {
                    chosenAll = false;
                    checkAll_btn.Text = "全选";
                    category_clb.SetItemChecked(i, false);
                }
            }
            else
            {
                for (int i = 0; i < category_clb.Items.Count; i++)
                {
                    chosenAll = true;
                    checkAll_btn.Text = "全部清除";
                    category_clb.SetItemChecked(i, true);
                }
            }
        }

        private void category_clb_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool hasGotIt = false;
            for (int i = 0; i < category_clb.Items.Count; i++)
            {
                if (!category_clb.GetItemChecked(i))
                {
                    chosenAll = false;
                    checkAll_btn.Text = "全选";
                    hasGotIt = true;
                }
                if (hasGotIt)
                {
                    break;
                }
            }
            if (!hasGotIt)
            {
                chosenAll = true;
                checkAll_btn.Text = "全部清除";
            }
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            model.clearData = true;
        }
    }
}
