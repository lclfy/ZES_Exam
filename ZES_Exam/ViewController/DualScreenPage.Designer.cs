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
            this.question_lbl = new CCWin.SkinControl.SkinLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.answer_lbl = new CCWin.SkinControl.SkinLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // question_lbl
            // 
            this.question_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.question_lbl.BackColor = System.Drawing.Color.Transparent;
            this.question_lbl.BorderColor = System.Drawing.Color.White;
            this.question_lbl.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.question_lbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.question_lbl.Location = new System.Drawing.Point(138, 101);
            this.question_lbl.MaximumSize = new System.Drawing.Size(720, 250);
            this.question_lbl.MinimumSize = new System.Drawing.Size(720, 250);
            this.question_lbl.Name = "question_lbl";
            this.question_lbl.Size = new System.Drawing.Size(720, 250);
            this.question_lbl.TabIndex = 4;
            this.question_lbl.Text = "题目";
            this.question_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.answer_lbl);
            this.panel1.Location = new System.Drawing.Point(138, 390);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 237);
            this.panel1.TabIndex = 5;
            // 
            // answer_lbl
            // 
            this.answer_lbl.AutoSize = true;
            this.answer_lbl.BackColor = System.Drawing.Color.Transparent;
            this.answer_lbl.BorderColor = System.Drawing.Color.White;
            this.answer_lbl.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.answer_lbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.answer_lbl.Location = new System.Drawing.Point(67, 10);
            this.answer_lbl.MaximumSize = new System.Drawing.Size(650, 0);
            this.answer_lbl.MinimumSize = new System.Drawing.Size(650, 0);
            this.answer_lbl.Name = "answer_lbl";
            this.answer_lbl.Size = new System.Drawing.Size(650, 31);
            this.answer_lbl.TabIndex = 1;
            this.answer_lbl.Text = "Answers";
            this.answer_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DualScreenPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1024, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.question_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "DualScreenPage";
            this.Text = "";
            this.Load += new System.EventHandler(this.DualScreenPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public CCWin.SkinControl.SkinLabel question_lbl;
        public System.Windows.Forms.Panel panel1;
        public CCWin.SkinControl.SkinLabel answer_lbl;
    }
}