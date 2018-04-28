using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ZES_Exam
{
    public class mySorter : IComparer
    {
        private Comparer comparer;
        private int sortColumn;
        private SortOrder sortOrder;
        public mySorter()
        {
            sortColumn = 0;
            sortOrder = SortOrder.None;
            comparer = Comparer.Default;
        }
        //指定进行排序的列
        public int SortColumn
        {
            get { return sortColumn; }
            set { sortColumn = value; }
        }
        //指定按升序或降序进行排序
        public SortOrder SortOrder
        {
            get { return sortOrder; }
            set { sortOrder = value; }
        }
        public int Compare(object x, object y)
        {
            int CompareResult;
            ListViewItem itemX = (ListViewItem)x;
            ListViewItem itemY = (ListViewItem)y;
            //在这里您可以提供自定义的排序
            int a = 0;
            int b = 0;
            int.TryParse(itemX.SubItems[this.sortColumn].Text, out a);
            int.TryParse(itemY.SubItems[this.sortColumn].Text, out b);
            CompareResult = comparer.Compare(a, b);
            if (this.SortOrder == SortOrder.Ascending)
                return CompareResult;
            else
            if (this.SortOrder == SortOrder.Descending)
                return (-CompareResult);
            else
                return 0;
        }
    }
}
