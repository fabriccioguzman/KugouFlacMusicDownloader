using System;
using System.Collections;
using System.Windows.Forms;

namespace com.yhen.downloader.module
{
    public class ListViewSort : IComparer
    {
        private readonly int _col;
        private readonly bool _descK;

        public ListViewSort()
        {
            _col = 0;
        }

        public ListViewSort(int column, object desc)
        {
            _descK = (bool)desc;
            _col = column; //当前列,0,1,2...,参数由ListView控件的ColumnClick事件传递    
        }

        public int Compare(object x, object y)
        {
            int tempInt = String.CompareOrdinal(((ListViewItem)x).SubItems[_col].Text,
                                                ((ListViewItem)y).SubItems[_col].Text);
            if (_descK)
            {
                return -tempInt;
            }
            return tempInt;
        }
    }
}
