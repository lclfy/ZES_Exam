namespace ZES_Exam
{
    partial class StudentListCheck
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
            this.name_lv = new CCWin.SkinControl.SkinListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.score = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.title_lb = new CCWin.SkinControl.SkinLabel();
            this.SuspendLayout();
            // 
            // name_lv
            // 
            this.name_lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.score});
            this.name_lv.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.name_lv.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.name_lv.GridLines = true;
            this.name_lv.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.name_lv.Location = new System.Drawing.Point(7, 69);
            this.name_lv.Name = "name_lv";
            this.name_lv.OwnerDraw = true;
            this.name_lv.RowBackColor2 = System.Drawing.Color.Gainsboro;
            this.name_lv.ShowGroups = false;
            this.name_lv.Size = new System.Drawing.Size(302, 430);
            this.name_lv.TabIndex = 0;
            this.name_lv.UseCompatibleStateImageBehavior = false;
            this.name_lv.View = System.Windows.Forms.View.Details;
            this.name_lv.SelectedIndexChanged += new System.EventHandler(this.name_lv_SelectedIndexChanged);
            // 
            // name
            // 
            this.name.Text = "姓名";
            this.name.Width = 150;
            // 
            // score
            // 
            this.score.Text = "分数";
            this.score.Width = 150;
            // 
            // title_lb
            // 
            this.title_lb.BackColor = System.Drawing.Color.Transparent;
            this.title_lb.BorderColor = System.Drawing.Color.White;
            this.title_lb.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title_lb.Location = new System.Drawing.Point(7, 40);
            this.title_lb.MaximumSize = new System.Drawing.Size(302, 23);
            this.title_lb.MinimumSize = new System.Drawing.Size(302, 23);
            this.title_lb.Name = "title_lb";
            this.title_lb.Size = new System.Drawing.Size(302, 23);
            this.title_lb.TabIndex = 1;
            this.title_lb.Text = "班组名";
            this.title_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.title_lb.Click += new System.EventHandler(this.title_lb_Click);
            // 
            // StudentListCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CaptionBackColorBottom = System.Drawing.Color.WhiteSmoke;
            this.CaptionBackColorTop = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(316, 506);
            this.Controls.Add(this.title_lb);
            this.Controls.Add(this.name_lv);
            this.MaximumSize = new System.Drawing.Size(316, 506);
            this.MinimumSize = new System.Drawing.Size(316, 506);
            this.Name = "StudentListCheck";
            this.Text = "";
            this.Load += new System.EventHandler(this.StudentListCheck_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinListView name_lv;
        private CCWin.SkinControl.SkinLabel title_lb;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader score;
    }
}