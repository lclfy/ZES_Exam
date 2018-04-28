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
            this.title_gb = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.skinGroupBox1 = new CCWin.SkinControl.SkinGroupBox();
            this.wrong_lbl = new CCWin.SkinControl.SkinLabel();
            this.right_lbl = new CCWin.SkinControl.SkinLabel();
            this.rightTimer = new System.Windows.Forms.Timer(this.components);
            this.wrongTimer = new System.Windows.Forms.Timer(this.components);
            this.skinGroupBox2 = new CCWin.SkinControl.SkinGroupBox();
            this.rankMode_cb = new CCWin.SkinControl.SkinCheckBox();
            this.setting_btn = new CCWin.SkinControl.SkinButton();
            this.back_btn = new CCWin.SkinControl.SkinButton();
            this.name_lv = new System.Windows.Forms.ListView();
            this._name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._score = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.title_gb.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.skinGroupBox1.SuspendLayout();
            this.skinGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // question_lbl
            // 
            this.question_lbl.BackColor = System.Drawing.Color.Transparent;
            this.question_lbl.BorderColor = System.Drawing.Color.White;
            this.question_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.question_lbl.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.question_lbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.question_lbl.Location = new System.Drawing.Point(3, 17);
            this.question_lbl.MaximumSize = new System.Drawing.Size(720, 250);
            this.question_lbl.MinimumSize = new System.Drawing.Size(720, 250);
            this.question_lbl.Name = "question_lbl";
            this.question_lbl.Size = new System.Drawing.Size(720, 250);
            this.question_lbl.TabIndex = 0;
            this.question_lbl.Text = "题目";
            this.question_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.question_lbl.Click += new System.EventHandler(this.question_lbl_Click);
            // 
            // answer_lbl
            // 
            this.answer_lbl.BackColor = System.Drawing.Color.Transparent;
            this.answer_lbl.BorderColor = System.Drawing.Color.White;
            this.answer_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.answer_lbl.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.answer_lbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.answer_lbl.Location = new System.Drawing.Point(3, 17);
            this.answer_lbl.MaximumSize = new System.Drawing.Size(720, 250);
            this.answer_lbl.MinimumSize = new System.Drawing.Size(720, 250);
            this.answer_lbl.Name = "answer_lbl";
            this.answer_lbl.Size = new System.Drawing.Size(720, 250);
            this.answer_lbl.TabIndex = 1;
            this.answer_lbl.Text = "Answers";
            this.answer_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roll_btn
            // 
            this.roll_btn.BackColor = System.Drawing.Color.Transparent;
            this.roll_btn.BaseColor = System.Drawing.Color.DodgerBlue;
            this.roll_btn.BorderColor = System.Drawing.Color.DodgerBlue;
            this.roll_btn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.roll_btn.DownBack = null;
            this.roll_btn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.roll_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.roll_btn.Location = new System.Drawing.Point(233, 609);
            this.roll_btn.MouseBack = null;
            this.roll_btn.Name = "roll_btn";
            this.roll_btn.NormlBack = null;
            this.roll_btn.Size = new System.Drawing.Size(187, 52);
            this.roll_btn.TabIndex = 2;
            this.roll_btn.Text = "抽题";
            this.roll_btn.UseVisualStyleBackColor = false;
            this.roll_btn.Click += new System.EventHandler(this.roll_btn_Click);
            // 
            // studentName_lbl
            // 
            this.studentName_lbl.BackColor = System.Drawing.Color.Transparent;
            this.studentName_lbl.BorderColor = System.Drawing.Color.White;
            this.studentName_lbl.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.studentName_lbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.studentName_lbl.Location = new System.Drawing.Point(6, 29);
            this.studentName_lbl.Name = "studentName_lbl";
            this.studentName_lbl.Size = new System.Drawing.Size(133, 25);
            this.studentName_lbl.TabIndex = 3;
            this.studentName_lbl.Text = "——";
            this.studentName_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selectStudent_btn
            // 
            this.selectStudent_btn.BackColor = System.Drawing.Color.Transparent;
            this.selectStudent_btn.BaseColor = System.Drawing.Color.DodgerBlue;
            this.selectStudent_btn.BorderColor = System.Drawing.Color.DodgerBlue;
            this.selectStudent_btn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.selectStudent_btn.DownBack = null;
            this.selectStudent_btn.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.selectStudent_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.selectStudent_btn.Location = new System.Drawing.Point(826, 563);
            this.selectStudent_btn.MouseBack = null;
            this.selectStudent_btn.Name = "selectStudent_btn";
            this.selectStudent_btn.NormlBack = null;
            this.selectStudent_btn.Size = new System.Drawing.Size(145, 39);
            this.selectStudent_btn.TabIndex = 4;
            this.selectStudent_btn.Text = "随机选人";
            this.selectStudent_btn.UseVisualStyleBackColor = false;
            this.selectStudent_btn.Click += new System.EventHandler(this.selectStudent_btn_Click);
            // 
            // rollingTimer
            // 
            this.rollingTimer.Tick += new System.EventHandler(this.rollingTimer_Tick);
            // 
            // studentTimer
            // 
            this.studentTimer.Interval = 75;
            this.studentTimer.Tick += new System.EventHandler(this.studentTimer_Tick);
            // 
            // wrong_btn
            // 
            this.wrong_btn.BackColor = System.Drawing.Color.Transparent;
            this.wrong_btn.BaseColor = System.Drawing.Color.Crimson;
            this.wrong_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.wrong_btn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.wrong_btn.DownBack = null;
            this.wrong_btn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.wrong_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.wrong_btn.Location = new System.Drawing.Point(74, 72);
            this.wrong_btn.MouseBack = null;
            this.wrong_btn.Name = "wrong_btn";
            this.wrong_btn.NormlBack = null;
            this.wrong_btn.Size = new System.Drawing.Size(61, 23);
            this.wrong_btn.TabIndex = 5;
            this.wrong_btn.Text = "×";
            this.wrong_btn.UseVisualStyleBackColor = false;
            this.wrong_btn.Click += new System.EventHandler(this.wrong_btn_Click);
            // 
            // right_btn
            // 
            this.right_btn.BackColor = System.Drawing.Color.Transparent;
            this.right_btn.BaseColor = System.Drawing.Color.DarkCyan;
            this.right_btn.BorderColor = System.Drawing.Color.Green;
            this.right_btn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.right_btn.DownBack = null;
            this.right_btn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.right_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.right_btn.Location = new System.Drawing.Point(11, 72);
            this.right_btn.MouseBack = null;
            this.right_btn.Name = "right_btn";
            this.right_btn.NormlBack = null;
            this.right_btn.Size = new System.Drawing.Size(61, 23);
            this.right_btn.TabIndex = 6;
            this.right_btn.Text = "√";
            this.right_btn.UseVisualStyleBackColor = false;
            this.right_btn.Click += new System.EventHandler(this.right_btn_Click);
            // 
            // splitScreen_btn
            // 
            this.splitScreen_btn.BackColor = System.Drawing.Color.Transparent;
            this.splitScreen_btn.BaseColor = System.Drawing.Color.DodgerBlue;
            this.splitScreen_btn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.splitScreen_btn.DownBack = null;
            this.splitScreen_btn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.splitScreen_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitScreen_btn.Location = new System.Drawing.Point(631, 45);
            this.splitScreen_btn.MouseBack = null;
            this.splitScreen_btn.Name = "splitScreen_btn";
            this.splitScreen_btn.NormlBack = null;
            this.splitScreen_btn.Size = new System.Drawing.Size(71, 32);
            this.splitScreen_btn.TabIndex = 7;
            this.splitScreen_btn.Text = "分屏模式";
            this.splitScreen_btn.UseVisualStyleBackColor = false;
            this.splitScreen_btn.Click += new System.EventHandler(this.splitScreen_btn_Click);
            // 
            // showRightAnswer_btn
            // 
            this.showRightAnswer_btn.BackColor = System.Drawing.Color.Transparent;
            this.showRightAnswer_btn.BaseColor = System.Drawing.Color.DodgerBlue;
            this.showRightAnswer_btn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.showRightAnswer_btn.DownBack = null;
            this.showRightAnswer_btn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.showRightAnswer_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.showRightAnswer_btn.Location = new System.Drawing.Point(426, 609);
            this.showRightAnswer_btn.MouseBack = null;
            this.showRightAnswer_btn.Name = "showRightAnswer_btn";
            this.showRightAnswer_btn.NormlBack = null;
            this.showRightAnswer_btn.Size = new System.Drawing.Size(187, 52);
            this.showRightAnswer_btn.TabIndex = 8;
            this.showRightAnswer_btn.Text = "显示答案";
            this.showRightAnswer_btn.UseVisualStyleBackColor = false;
            this.showRightAnswer_btn.Click += new System.EventHandler(this.showRightAnswer_btn_Click);
            // 
            // title_gb
            // 
            this.title_gb.Controls.Add(this.question_lbl);
            this.title_gb.Location = new System.Drawing.Point(55, 83);
            this.title_gb.Name = "title_gb";
            this.title_gb.Size = new System.Drawing.Size(720, 250);
            this.title_gb.TabIndex = 9;
            this.title_gb.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.answer_lbl);
            this.groupBox1.Location = new System.Drawing.Point(58, 339);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(720, 250);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // skinGroupBox1
            // 
            this.skinGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.skinGroupBox1.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.skinGroupBox1.Controls.Add(this.wrong_lbl);
            this.skinGroupBox1.Controls.Add(this.right_lbl);
            this.skinGroupBox1.Controls.Add(this.studentName_lbl);
            this.skinGroupBox1.Controls.Add(this.right_btn);
            this.skinGroupBox1.Controls.Add(this.wrong_btn);
            this.skinGroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.skinGroupBox1.Font = new System.Drawing.Font("微软雅黑 Light", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinGroupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.skinGroupBox1.Location = new System.Drawing.Point(826, 445);
            this.skinGroupBox1.Name = "skinGroupBox1";
            this.skinGroupBox1.RectBackColor = System.Drawing.Color.White;
            this.skinGroupBox1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox1.Size = new System.Drawing.Size(145, 105);
            this.skinGroupBox1.TabIndex = 13;
            this.skinGroupBox1.TabStop = false;
            this.skinGroupBox1.Text = " 计分";
            this.skinGroupBox1.TitleBorderColor = System.Drawing.Color.DarkGray;
            this.skinGroupBox1.TitleRectBackColor = System.Drawing.Color.Gray;
            this.skinGroupBox1.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // wrong_lbl
            // 
            this.wrong_lbl.AutoSize = true;
            this.wrong_lbl.BackColor = System.Drawing.Color.Transparent;
            this.wrong_lbl.BorderColor = System.Drawing.Color.White;
            this.wrong_lbl.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.wrong_lbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.wrong_lbl.Location = new System.Drawing.Point(77, 53);
            this.wrong_lbl.Name = "wrong_lbl";
            this.wrong_lbl.Size = new System.Drawing.Size(56, 17);
            this.wrong_lbl.TabIndex = 8;
            this.wrong_lbl.Text = "记录成功";
            this.wrong_lbl.Visible = false;
            // 
            // right_lbl
            // 
            this.right_lbl.AutoSize = true;
            this.right_lbl.BackColor = System.Drawing.Color.Transparent;
            this.right_lbl.BorderColor = System.Drawing.Color.White;
            this.right_lbl.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.right_lbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.right_lbl.Location = new System.Drawing.Point(16, 53);
            this.right_lbl.Name = "right_lbl";
            this.right_lbl.Size = new System.Drawing.Size(56, 17);
            this.right_lbl.TabIndex = 7;
            this.right_lbl.Text = "记录成功";
            this.right_lbl.Visible = false;
            // 
            // rightTimer
            // 
            this.rightTimer.Interval = 1000;
            this.rightTimer.Tick += new System.EventHandler(this.tipTimer_Tick);
            // 
            // wrongTimer
            // 
            this.wrongTimer.Interval = 1000;
            this.wrongTimer.Tick += new System.EventHandler(this.wrongTimer_Tick);
            // 
            // skinGroupBox2
            // 
            this.skinGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.skinGroupBox2.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.skinGroupBox2.Controls.Add(this.rankMode_cb);
            this.skinGroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.skinGroupBox2.Font = new System.Drawing.Font("微软雅黑 Light", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinGroupBox2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.skinGroupBox2.Location = new System.Drawing.Point(826, 609);
            this.skinGroupBox2.Name = "skinGroupBox2";
            this.skinGroupBox2.RectBackColor = System.Drawing.Color.White;
            this.skinGroupBox2.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox2.Size = new System.Drawing.Size(145, 54);
            this.skinGroupBox2.TabIndex = 14;
            this.skinGroupBox2.TabStop = false;
            this.skinGroupBox2.Text = "竞赛计分";
            this.skinGroupBox2.TitleBorderColor = System.Drawing.Color.DarkGray;
            this.skinGroupBox2.TitleRectBackColor = System.Drawing.Color.Gray;
            this.skinGroupBox2.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // rankMode_cb
            // 
            this.rankMode_cb.AutoSize = true;
            this.rankMode_cb.BackColor = System.Drawing.Color.Transparent;
            this.rankMode_cb.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.rankMode_cb.DownBack = null;
            this.rankMode_cb.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rankMode_cb.ForeColor = System.Drawing.Color.Black;
            this.rankMode_cb.Location = new System.Drawing.Point(49, 23);
            this.rankMode_cb.MouseBack = null;
            this.rankMode_cb.Name = "rankMode_cb";
            this.rankMode_cb.NormlBack = null;
            this.rankMode_cb.SelectedDownBack = null;
            this.rankMode_cb.SelectedMouseBack = null;
            this.rankMode_cb.SelectedNormlBack = null;
            this.rankMode_cb.Size = new System.Drawing.Size(51, 21);
            this.rankMode_cb.TabIndex = 0;
            this.rankMode_cb.Text = "启用";
            this.rankMode_cb.UseVisualStyleBackColor = false;
            this.rankMode_cb.CheckedChanged += new System.EventHandler(this.rankMode_cb_CheckedChanged);
            // 
            // setting_btn
            // 
            this.setting_btn.BackColor = System.Drawing.Color.Transparent;
            this.setting_btn.BaseColor = System.Drawing.Color.Crimson;
            this.setting_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.setting_btn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.setting_btn.DownBack = null;
            this.setting_btn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.setting_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.setting_btn.Location = new System.Drawing.Point(704, 45);
            this.setting_btn.MouseBack = null;
            this.setting_btn.Name = "setting_btn";
            this.setting_btn.NormlBack = null;
            this.setting_btn.Size = new System.Drawing.Size(71, 32);
            this.setting_btn.TabIndex = 1;
            this.setting_btn.Text = "设置";
            this.setting_btn.UseVisualStyleBackColor = false;
            this.setting_btn.Click += new System.EventHandler(this.setting_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.Transparent;
            this.back_btn.BaseColor = System.Drawing.Color.OrangeRed;
            this.back_btn.BorderColor = System.Drawing.Color.DarkOrange;
            this.back_btn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.back_btn.DownBack = null;
            this.back_btn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.back_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.back_btn.Location = new System.Drawing.Point(55, 45);
            this.back_btn.MouseBack = null;
            this.back_btn.Name = "back_btn";
            this.back_btn.NormlBack = null;
            this.back_btn.Size = new System.Drawing.Size(94, 32);
            this.back_btn.TabIndex = 15;
            this.back_btn.Text = "返回选择界面";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // name_lv
            // 
            this.name_lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._name,
            this._score});
            this.name_lv.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.name_lv.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.name_lv.Location = new System.Drawing.Point(827, 89);
            this.name_lv.MultiSelect = false;
            this.name_lv.Name = "name_lv";
            this.name_lv.Size = new System.Drawing.Size(138, 350);
            this.name_lv.TabIndex = 16;
            this.name_lv.UseCompatibleStateImageBehavior = false;
            this.name_lv.View = System.Windows.Forms.View.Details;
            this.name_lv.SelectedIndexChanged += new System.EventHandler(this.name_lv_SelectedIndexChanged);
            // 
            // _name
            // 
            this._name.Text = "姓名";
            this._name.Width = 70;
            // 
            // _score
            // 
            this._score.Text = "成绩";
            this._score.Width = 70;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackLayout = false;
            this.BorderColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1024, 700);
            this.Controls.Add(this.name_lv);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.setting_btn);
            this.Controls.Add(this.skinGroupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.showRightAnswer_btn);
            this.Controls.Add(this.splitScreen_btn);
            this.Controls.Add(this.selectStudent_btn);
            this.Controls.Add(this.roll_btn);
            this.Controls.Add(this.title_gb);
            this.Controls.Add(this.skinGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MdiBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "MainPage";
            this.Text = "";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.title_gb.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.skinGroupBox1.ResumeLayout(false);
            this.skinGroupBox1.PerformLayout();
            this.skinGroupBox2.ResumeLayout(false);
            this.skinGroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
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
        private CCWin.SkinControl.SkinLabel question_lbl;
        private System.Windows.Forms.GroupBox title_gb;
        private System.Windows.Forms.GroupBox groupBox1;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox1;
        private CCWin.SkinControl.SkinLabel wrong_lbl;
        private CCWin.SkinControl.SkinLabel right_lbl;
        private System.Windows.Forms.Timer rightTimer;
        private System.Windows.Forms.Timer wrongTimer;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox2;
        private CCWin.SkinControl.SkinButton setting_btn;
        private CCWin.SkinControl.SkinButton back_btn;
        public CCWin.SkinControl.SkinCheckBox rankMode_cb;
        private System.Windows.Forms.ColumnHeader _name;
        private System.Windows.Forms.ColumnHeader _score;
        public System.Windows.Forms.ListView name_lv;
    }
}