﻿using System;
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

namespace ZES_Exam
{
    public partial class StudentListCheck : Skin_Mac
    {
        List<Students> students = new List<Students>();
        string title = "";
        public StudentListCheck(IWorkbook _nameWorkbook)
        {
            students = getStudents(_nameWorkbook);
            InitializeComponent();
        }

        private List<Students> getStudents(IWorkbook _nameWorkbook)
        {
            List<Students> _students = new List<Students>();
            ISheet sheet = _nameWorkbook.GetSheetAt(0);  //获取第一个工作表  
            //标题
            if(sheet.GetRow(0) != null)
            {
                if (sheet.GetRow(0).GetCell(0) != null)
                {
                    title = sheet.GetRow(0).GetCell(0).ToString().Trim();
                }
            }
            for (int i = 2; i <= sheet.LastRowNum; i++)
            {
                IRow row;
                if (sheet.GetRow(i) != null)
                {
                    row = sheet.GetRow(i);
                    Students _s = new Students();
                    if (row.GetCell(0) != null)
                    {
                        _s.name = row.GetCell(0).ToString().Trim();
                    }
                    else
                    {
                        _s.grade = "0";
                    }
                    _students.Add(_s);
                }
                else
                {
                    continue;
                }
            }
            return _students;
        }

        private void StudentListCheck_Load(object sender, EventArgs e)
        {
            title_lb.Text = title;
            name_lv.BeginUpdate();
            foreach (Students _s in students)
            {
                ListViewItem _lvi = new ListViewItem(_s.name);
                name_lv.Items.Add(_lvi);
            }
            name_lv.EndUpdate();
            
        }
    }
}
