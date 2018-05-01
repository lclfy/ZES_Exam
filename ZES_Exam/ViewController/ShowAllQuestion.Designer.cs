namespace ZES_Exam
{
    partial class ShowAllQuestion
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
            this.questions_lv = new System.Windows.Forms.ListView();
            this.questionName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.questionCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.search_tb = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.SuspendLayout();
            // 
            // questions_lv
            // 
            this.questions_lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.questionName,
            this.questionCategory});
            this.questions_lv.Cursor = System.Windows.Forms.Cursors.Default;
            this.questions_lv.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.questions_lv.ForeColor = System.Drawing.SystemColors.WindowText;
            this.questions_lv.FullRowSelect = true;
            this.questions_lv.Location = new System.Drawing.Point(22, 75);
            this.questions_lv.MultiSelect = false;
            this.questions_lv.Name = "questions_lv";
            this.questions_lv.Size = new System.Drawing.Size(402, 500);
            this.questions_lv.TabIndex = 0;
            this.questions_lv.UseCompatibleStateImageBehavior = false;
            this.questions_lv.View = System.Windows.Forms.View.Details;
            this.questions_lv.SelectedIndexChanged += new System.EventHandler(this.questions_lv_SelectedIndexChanged);
            this.questions_lv.Click += new System.EventHandler(this.questions_lv_Click);
            this.questions_lv.DoubleClick += new System.EventHandler(this.questions_lv_DoubleClick);
            // 
            // questionName
            // 
            this.questionName.Text = "题目名称";
            this.questionName.Width = 250;
            // 
            // questionCategory
            // 
            this.questionCategory.Text = "题目分类";
            this.questionCategory.Width = 140;
            // 
            // search_tb
            // 
            this.search_tb.BackColor = System.Drawing.Color.White;
            this.search_tb.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.search_tb.ForeColor = System.Drawing.SystemColors.Highlight;
            this.search_tb.Location = new System.Drawing.Point(81, 43);
            this.search_tb.Name = "search_tb";
            this.search_tb.Size = new System.Drawing.Size(343, 26);
            this.search_tb.TabIndex = 10;
            this.search_tb.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.search_tb.WaterText = "";
            this.search_tb.TextChanged += new System.EventHandler(this.search_tb_TextChanged);
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(19, 48);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(56, 17);
            this.skinLabel1.TabIndex = 11;
            this.skinLabel1.Text = "搜索题目";
            // 
            // ShowAllQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 607);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.search_tb);
            this.Controls.Add(this.questions_lv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ShowAllQuestion";
            this.Text = "";
            this.Load += new System.EventHandler(this.ShowAllQuestion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView questions_lv;
        private CCWin.SkinControl.SkinWaterTextBox search_tb;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private System.Windows.Forms.ColumnHeader questionName;
        private System.Windows.Forms.ColumnHeader questionCategory;
    }
}