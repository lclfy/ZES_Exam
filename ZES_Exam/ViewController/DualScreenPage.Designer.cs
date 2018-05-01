namespace ZES_Exam
{
    partial class DualScreenPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DualScreenPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.answer_lbl = new CCWin.SkinControl.SkinLabel();
            this.name_lv = new System.Windows.Forms.ListView();
            this._name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._score = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.question_lbl = new CCWin.SkinControl.SkinLabel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.timerText_lbl = new CCWin.SkinControl.SkinLabel();
            this.timer_lbl = new CCWin.SkinControl.SkinLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.skinLabel1);
            this.panel1.Controls.Add(this.answer_lbl);
            this.panel1.Location = new System.Drawing.Point(127, 428);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(641, 240);
            this.panel1.TabIndex = 5;
            // 
            // answer_lbl
            // 
            this.answer_lbl.AutoSize = true;
            this.answer_lbl.BackColor = System.Drawing.Color.Transparent;
            this.answer_lbl.BorderColor = System.Drawing.Color.Transparent;
            this.answer_lbl.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.answer_lbl.ForeColor = System.Drawing.Color.White;
            this.answer_lbl.Location = new System.Drawing.Point(20, 40);
            this.answer_lbl.MaximumSize = new System.Drawing.Size(620, 0);
            this.answer_lbl.MinimumSize = new System.Drawing.Size(620, 0);
            this.answer_lbl.Name = "answer_lbl";
            this.answer_lbl.Size = new System.Drawing.Size(620, 28);
            this.answer_lbl.TabIndex = 1;
            this.answer_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // name_lv
            // 
            this.name_lv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("name_lv.BackgroundImage")));
            this.name_lv.BackgroundImageTiled = true;
            this.name_lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._name,
            this._score});
            this.name_lv.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.name_lv.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.name_lv.GridLines = true;
            this.name_lv.Location = new System.Drawing.Point(821, 101);
            this.name_lv.MultiSelect = false;
            this.name_lv.Name = "name_lv";
            this.name_lv.Size = new System.Drawing.Size(156, 526);
            this.name_lv.TabIndex = 17;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.question_lbl);
            this.panel2.Location = new System.Drawing.Point(85, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(720, 320);
            this.panel2.TabIndex = 21;
            // 
            // question_lbl
            // 
            this.question_lbl.BackColor = System.Drawing.Color.Transparent;
            this.question_lbl.BorderColor = System.Drawing.Color.Transparent;
            this.question_lbl.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.question_lbl.ForeColor = System.Drawing.Color.White;
            this.question_lbl.Location = new System.Drawing.Point(6, 0);
            this.question_lbl.MaximumSize = new System.Drawing.Size(700, 320);
            this.question_lbl.MinimumSize = new System.Drawing.Size(700, 250);
            this.question_lbl.Name = "question_lbl";
            this.question_lbl.Size = new System.Drawing.Size(700, 320);
            this.question_lbl.TabIndex = 0;
            this.question_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.Silver;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.ForeColor = System.Drawing.Color.White;
            this.skinLabel1.Location = new System.Drawing.Point(20, 13);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(52, 27);
            this.skinLabel1.TabIndex = 22;
            this.skinLabel1.Text = "答案";
            // 
            // timerText_lbl
            // 
            this.timerText_lbl.AutoSize = true;
            this.timerText_lbl.BackColor = System.Drawing.Color.Transparent;
            this.timerText_lbl.BorderColor = System.Drawing.Color.White;
            this.timerText_lbl.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.timerText_lbl.Location = new System.Drawing.Point(82, 58);
            this.timerText_lbl.Name = "timerText_lbl";
            this.timerText_lbl.Size = new System.Drawing.Size(44, 17);
            this.timerText_lbl.TabIndex = 24;
            this.timerText_lbl.Text = "计时器";
            // 
            // timer_lbl
            // 
            this.timer_lbl.AutoSize = true;
            this.timer_lbl.BackColor = System.Drawing.Color.Transparent;
            this.timer_lbl.BorderColor = System.Drawing.Color.White;
            this.timer_lbl.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.timer_lbl.ForeColor = System.Drawing.Color.Crimson;
            this.timer_lbl.Location = new System.Drawing.Point(132, 41);
            this.timer_lbl.Name = "timer_lbl";
            this.timer_lbl.Size = new System.Drawing.Size(92, 38);
            this.timer_lbl.TabIndex = 23;
            this.timer_lbl.Text = "00:00";
            // 
            // DualScreenPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CaptionBackColorBottom = System.Drawing.Color.Transparent;
            this.CaptionBackColorTop = System.Drawing.Color.Transparent;
            this.ClientSize = new System.Drawing.Size(1024, 730);
            this.Controls.Add(this.timerText_lbl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.timer_lbl);
            this.Controls.Add(this.name_lv);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximumSize = new System.Drawing.Size(1024, 730);
            this.Name = "DualScreenPage";
            this.Text = "";
            this.Load += new System.EventHandler(this.DualScreenPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Panel panel1;
        public CCWin.SkinControl.SkinLabel answer_lbl;
        public System.Windows.Forms.ListView name_lv;
        private System.Windows.Forms.ColumnHeader _name;
        private System.Windows.Forms.ColumnHeader _score;
        public System.Windows.Forms.Panel panel2;
        public CCWin.SkinControl.SkinLabel question_lbl;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel timerText_lbl;
        public CCWin.SkinControl.SkinLabel timer_lbl;
    }
}