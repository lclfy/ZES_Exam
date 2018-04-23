namespace ZES_Exam
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.question_lbl = new CCWin.SkinControl.SkinLabel();
            this.answer_lbl = new CCWin.SkinControl.SkinLabel();
            this.roll_btn = new CCWin.SkinControl.SkinButton();
            this.studentName_lbl = new CCWin.SkinControl.SkinLabel();
            this.selectStudent_btn = new CCWin.SkinControl.SkinButton();
            this.rollingTimer = new System.Windows.Forms.Timer(this.components);
            this.studentTimer = new System.Windows.Forms.Timer(this.components);
            this.wrong_btn = new CCWin.SkinControl.SkinButton();
            this.right_btn = new CCWin.SkinControl.SkinButton();
            this.splitScreen_btn = new CCWin.SkinControl.SkinButton();
            this.showRightAnswer_btn = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // question_lbl
            // 
            this.question_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.question_lbl.BackColor = System.Drawing.Color.Transparent;
            this.question_lbl.BorderColor = System.Drawing.Color.White;
            this.question_lbl.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.question_lbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.question_lbl.Location = new System.Drawing.Point(48, 77);
            this.question_lbl.MaximumSize = new System.Drawing.Size(500, 150);
            this.question_lbl.MinimumSize = new System.Drawing.Size(500, 150);
            this.question_lbl.Name = "question_lbl";
            this.question_lbl.Size = new System.Drawing.Size(500, 150);
            this.question_lbl.TabIndex = 0;
            this.question_lbl.Text = "题目";
            this.question_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answer_lbl
            // 
            this.answer_lbl.BackColor = System.Drawing.Color.Transparent;
            this.answer_lbl.BorderColor = System.Drawing.Color.White;
            this.answer_lbl.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.answer_lbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.answer_lbl.Location = new System.Drawing.Point(51, 251);
            this.answer_lbl.MaximumSize = new System.Drawing.Size(500, 100);
            this.answer_lbl.MinimumSize = new System.Drawing.Size(500, 100);
            this.answer_lbl.Name = "answer_lbl";
            this.answer_lbl.Size = new System.Drawing.Size(500, 100);
            this.answer_lbl.TabIndex = 1;
            this.answer_lbl.Text = "Answers";
            this.answer_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // roll_btn
            // 
            this.roll_btn.BackColor = System.Drawing.Color.Transparent;
            this.roll_btn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.roll_btn.DownBack = null;
            this.roll_btn.Location = new System.Drawing.Point(113, 366);
            this.roll_btn.MouseBack = null;
            this.roll_btn.Name = "roll_btn";
            this.roll_btn.NormlBack = null;
            this.roll_btn.Size = new System.Drawing.Size(187, 65);
            this.roll_btn.TabIndex = 2;
            this.roll_btn.Text = "抽题";
            this.roll_btn.UseVisualStyleBackColor = false;
            this.roll_btn.Click += new System.EventHandler(this.roll_btn_Click);
            // 
            // studentName_lbl
            // 
            this.studentName_lbl.AutoSize = true;
            this.studentName_lbl.BackColor = System.Drawing.Color.Transparent;
            this.studentName_lbl.BorderColor = System.Drawing.Color.White;
            this.studentName_lbl.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.studentName_lbl.Location = new System.Drawing.Point(648, 230);
            this.studentName_lbl.Name = "studentName_lbl";
            this.studentName_lbl.Size = new System.Drawing.Size(50, 25);
            this.studentName_lbl.TabIndex = 3;
            this.studentName_lbl.Text = "姓名";
            // 
            // selectStudent_btn
            // 
            this.selectStudent_btn.BackColor = System.Drawing.Color.Transparent;
            this.selectStudent_btn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.selectStudent_btn.DownBack = null;
            this.selectStudent_btn.Location = new System.Drawing.Point(636, 275);
            this.selectStudent_btn.MouseBack = null;
            this.selectStudent_btn.Name = "selectStudent_btn";
            this.selectStudent_btn.NormlBack = null;
            this.selectStudent_btn.Size = new System.Drawing.Size(76, 42);
            this.selectStudent_btn.TabIndex = 4;
            this.selectStudent_btn.Text = "抽人";
            this.selectStudent_btn.UseVisualStyleBackColor = false;
            this.selectStudent_btn.Click += new System.EventHandler(this.selectStudent_btn_Click);
            // 
            // rollingTimer
            // 
            this.rollingTimer.Tick += new System.EventHandler(this.rollingTimer_Tick);
            // 
            // studentTimer
            // 
            this.studentTimer.Tick += new System.EventHandler(this.studentTimer_Tick);
            // 
            // wrong_btn
            // 
            this.wrong_btn.BackColor = System.Drawing.Color.Transparent;
            this.wrong_btn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.wrong_btn.DownBack = null;
            this.wrong_btn.Location = new System.Drawing.Point(637, 408);
            this.wrong_btn.MouseBack = null;
            this.wrong_btn.Name = "wrong_btn";
            this.wrong_btn.NormlBack = null;
            this.wrong_btn.Size = new System.Drawing.Size(75, 23);
            this.wrong_btn.TabIndex = 5;
            this.wrong_btn.Text = "错误";
            this.wrong_btn.UseVisualStyleBackColor = false;
            this.wrong_btn.Click += new System.EventHandler(this.wrong_btn_Click);
            // 
            // right_btn
            // 
            this.right_btn.BackColor = System.Drawing.Color.Transparent;
            this.right_btn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.right_btn.DownBack = null;
            this.right_btn.Location = new System.Drawing.Point(637, 379);
            this.right_btn.MouseBack = null;
            this.right_btn.Name = "right_btn";
            this.right_btn.NormlBack = null;
            this.right_btn.Size = new System.Drawing.Size(75, 23);
            this.right_btn.TabIndex = 6;
            this.right_btn.Text = "正确";
            this.right_btn.UseVisualStyleBackColor = false;
            this.right_btn.Click += new System.EventHandler(this.right_btn_Click);
            // 
            // splitScreen_btn
            // 
            this.splitScreen_btn.BackColor = System.Drawing.Color.Transparent;
            this.splitScreen_btn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.splitScreen_btn.DownBack = null;
            this.splitScreen_btn.Location = new System.Drawing.Point(29, 51);
            this.splitScreen_btn.MouseBack = null;
            this.splitScreen_btn.Name = "splitScreen_btn";
            this.splitScreen_btn.NormlBack = null;
            this.splitScreen_btn.Size = new System.Drawing.Size(75, 23);
            this.splitScreen_btn.TabIndex = 7;
            this.splitScreen_btn.Text = "分屏模式";
            this.splitScreen_btn.UseVisualStyleBackColor = false;
            this.splitScreen_btn.Click += new System.EventHandler(this.splitScreen_btn_Click);
            // 
            // showRightAnswer_btn
            // 
            this.showRightAnswer_btn.BackColor = System.Drawing.Color.Transparent;
            this.showRightAnswer_btn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.showRightAnswer_btn.DownBack = null;
            this.showRightAnswer_btn.Location = new System.Drawing.Point(306, 366);
            this.showRightAnswer_btn.MouseBack = null;
            this.showRightAnswer_btn.Name = "showRightAnswer_btn";
            this.showRightAnswer_btn.NormlBack = null;
            this.showRightAnswer_btn.Size = new System.Drawing.Size(187, 65);
            this.showRightAnswer_btn.TabIndex = 8;
            this.showRightAnswer_btn.Text = "在分屏中显示答案";
            this.showRightAnswer_btn.UseVisualStyleBackColor = false;
            this.showRightAnswer_btn.Click += new System.EventHandler(this.showRightAnswer_btn_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 475);
            this.Controls.Add(this.showRightAnswer_btn);
            this.Controls.Add(this.splitScreen_btn);
            this.Controls.Add(this.right_btn);
            this.Controls.Add(this.wrong_btn);
            this.Controls.Add(this.selectStudent_btn);
            this.Controls.Add(this.studentName_lbl);
            this.Controls.Add(this.roll_btn);
            this.Controls.Add(this.answer_lbl);
            this.Controls.Add(this.question_lbl);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinLabel question_lbl;
        private CCWin.SkinControl.SkinLabel answer_lbl;
        private CCWin.SkinControl.SkinButton roll_btn;
        private CCWin.SkinControl.SkinLabel studentName_lbl;
        private CCWin.SkinControl.SkinButton selectStudent_btn;
        private System.Windows.Forms.Timer rollingTimer;
        private System.Windows.Forms.Timer studentTimer;
        private CCWin.SkinControl.SkinButton wrong_btn;
        private CCWin.SkinControl.SkinButton right_btn;
        private CCWin.SkinControl.SkinButton splitScreen_btn;
        private CCWin.SkinControl.SkinButton showRightAnswer_btn;
    }
}