﻿namespace ZES_Exam
{
    partial class StartPage
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.nameComboBox = new CCWin.SkinControl.SkinComboBox();
            this.examPaperComboBox = new CCWin.SkinControl.SkinComboBox();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.startButton = new CCWin.SkinControl.SkinButton();
            this.checkName_btn = new System.Windows.Forms.Label();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.selectScore_btn = new System.Windows.Forms.Label();
            this.selectSavedScore_lv = new System.Windows.Forms.ListView();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.White;
            this.skinLabel1.BorderColor = System.Drawing.Color.Transparent;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.skinLabel1.Location = new System.Drawing.Point(208, 51);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(75, 38);
            this.skinLabel1.TabIndex = 1;
            this.skinLabel1.Text = "欢迎";
            // 
            // nameComboBox
            // 
            this.nameComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.nameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nameComboBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nameComboBox.FormattingEnabled = true;
            this.nameComboBox.Location = new System.Drawing.Point(149, 121);
            this.nameComboBox.MaxDropDownItems = 100;
            this.nameComboBox.Name = "nameComboBox";
            this.nameComboBox.Size = new System.Drawing.Size(253, 30);
            this.nameComboBox.TabIndex = 2;
            this.nameComboBox.WaterText = "";
            this.nameComboBox.SelectedIndexChanged += new System.EventHandler(this.nameComboBox_SelectedIndexChanged);
            // 
            // examPaperComboBox
            // 
            this.examPaperComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.examPaperComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.examPaperComboBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.examPaperComboBox.FormattingEnabled = true;
            this.examPaperComboBox.Location = new System.Drawing.Point(149, 167);
            this.examPaperComboBox.Name = "examPaperComboBox";
            this.examPaperComboBox.Size = new System.Drawing.Size(253, 30);
            this.examPaperComboBox.TabIndex = 3;
            this.examPaperComboBox.WaterText = "";
            this.examPaperComboBox.SelectedIndexChanged += new System.EventHandler(this.skinComboBox2_SelectedIndexChanged);
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(76, 172);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(56, 17);
            this.skinLabel2.TabIndex = 4;
            this.skinLabel2.Text = "选择题库";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.skinLabel3.Location = new System.Drawing.Point(76, 128);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(56, 17);
            this.skinLabel3.TabIndex = 5;
            this.skinLabel3.Text = "选择名单";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Transparent;
            this.startButton.BaseColor = System.Drawing.Color.DodgerBlue;
            this.startButton.BorderColor = System.Drawing.Color.Transparent;
            this.startButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.startButton.DownBack = null;
            this.startButton.DownBaseColor = System.Drawing.Color.Black;
            this.startButton.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.startButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.startButton.InnerBorderColor = System.Drawing.Color.DimGray;
            this.startButton.Location = new System.Drawing.Point(79, 233);
            this.startButton.MouseBack = null;
            this.startButton.Name = "startButton";
            this.startButton.NormlBack = null;
            this.startButton.Size = new System.Drawing.Size(323, 43);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "开始";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // checkName_btn
            // 
            this.checkName_btn.AutoSize = true;
            this.checkName_btn.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkName_btn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.checkName_btn.Location = new System.Drawing.Point(145, 287);
            this.checkName_btn.Name = "checkName_btn";
            this.checkName_btn.Size = new System.Drawing.Size(65, 20);
            this.checkName_btn.TabIndex = 9;
            this.checkName_btn.Text = "查看名单";
            this.checkName_btn.Click += new System.EventHandler(this.checkName_btn_Click);
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(153, 208);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(179, 17);
            this.skinLabel4.TabIndex = 10;
            this.skinLabel4.Text = "请使用2003版Excel文件（.xls）";
            // 
            // selectScore_btn
            // 
            this.selectScore_btn.AutoSize = true;
            this.selectScore_btn.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.selectScore_btn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.selectScore_btn.Location = new System.Drawing.Point(267, 287);
            this.selectScore_btn.Name = "selectScore_btn";
            this.selectScore_btn.Size = new System.Drawing.Size(85, 20);
            this.selectScore_btn.TabIndex = 11;
            this.selectScore_btn.Text = "计分记录>>";
            this.selectScore_btn.Click += new System.EventHandler(this.selectScore_btn_Click);
            // 
            // selectSavedScore_lv
            // 
            this.selectSavedScore_lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.title,
            this.time});
            this.selectSavedScore_lv.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.selectSavedScore_lv.FullRowSelect = true;
            this.selectSavedScore_lv.Location = new System.Drawing.Point(463, 121);
            this.selectSavedScore_lv.MultiSelect = false;
            this.selectSavedScore_lv.Name = "selectSavedScore_lv";
            this.selectSavedScore_lv.Size = new System.Drawing.Size(180, 155);
            this.selectSavedScore_lv.TabIndex = 12;
            this.selectSavedScore_lv.UseCompatibleStateImageBehavior = false;
            this.selectSavedScore_lv.View = System.Windows.Forms.View.Details;
            this.selectSavedScore_lv.Visible = false;
            this.selectSavedScore_lv.SelectedIndexChanged += new System.EventHandler(this.selectSavedScore_lv_SelectedIndexChanged);
            this.selectSavedScore_lv.DoubleClick += new System.EventHandler(this.selectSavedScore_lv_DoubleClick);
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(457, 290);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(191, 17);
            this.skinLabel5.TabIndex = 13;
            this.skinLabel5.Text = "选择想要继续的计分,双击查看详情";
            this.skinLabel5.Visible = false;
            // 
            // title
            // 
            this.title.Text = "试卷标题";
            this.title.Width = 90;
            // 
            // time
            // 
            this.time.Text = "保存时间";
            this.time.Width = 90;
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BorderColor = System.Drawing.Color.White;
            this.CaptionBackColorBottom = System.Drawing.Color.White;
            this.CaptionBackColorTop = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(489, 340);
            this.Controls.Add(this.skinLabel5);
            this.Controls.Add(this.selectSavedScore_lv);
            this.Controls.Add(this.selectScore_btn);
            this.Controls.Add(this.skinLabel4);
            this.Controls.Add(this.checkName_btn);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.examPaperComboBox);
            this.Controls.Add(this.nameComboBox);
            this.Controls.Add(this.skinLabel1);
            this.EffectBack = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximumSize = new System.Drawing.Size(700, 340);
            this.MinimumSize = new System.Drawing.Size(489, 340);
            this.Name = "StartPage";
            this.Text = "Form1";
            this.TitleColor = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.StartPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinComboBox nameComboBox;
        private CCWin.SkinControl.SkinComboBox examPaperComboBox;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinButton startButton;
        private System.Windows.Forms.Label checkName_btn;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private System.Windows.Forms.Label selectScore_btn;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private System.Windows.Forms.ColumnHeader title;
        private System.Windows.Forms.ColumnHeader time;
        public System.Windows.Forms.ListView selectSavedScore_lv;
    }
}

