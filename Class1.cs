using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace Movie_Maniacs
{
    class ColumnSorter : IComparer
    {
        public int CurrentColumn = 0;
        public int LastSorted;
        private int semn = 1;

        public ColumnSorter()
        {
        }

        public int Compare(object x, object y)
        {
            ListViewItem A = (ListViewItem)x;
            ListViewItem B = (ListViewItem)y;

            float a;
            DateTime b;

            if (float.TryParse(A.SubItems[CurrentColumn].Text.ToString(), out a) != false && float.TryParse(B.SubItems[CurrentColumn].Text.ToString(), out a) == true)
            {
                    if (float.Parse(A.SubItems[CurrentColumn].Text.ToString()) < float.Parse(B.SubItems[CurrentColumn].Text.ToString()))
                        return semn*1;
                    else if (float.Parse(A.SubItems[CurrentColumn].Text.ToString()) > float.Parse(B.SubItems[CurrentColumn].Text.ToString()))
                        return semn*-1;
                    else
                        return 0;
            }
            else if (DateTime.TryParse(A.SubItems[CurrentColumn].Text.ToString(), out b) == true && DateTime.TryParse(B.SubItems[CurrentColumn].Text.ToString(), out b) == true)
            {
                if (DateTime.Parse(A.SubItems[CurrentColumn].Text.ToString()) < DateTime.Parse(B.SubItems[CurrentColumn].Text.ToString()))
                    return semn * 1;
                else if (DateTime.Parse(A.SubItems[CurrentColumn].Text.ToString()) > DateTime.Parse(B.SubItems[CurrentColumn].Text.ToString()))
                    return semn * -1;
                else
                    return 0;
            }
            else
            {
                if (A.SubItems[CurrentColumn].Text.ToString() == "")
                    return semn * 1;
                else if (B.SubItems[CurrentColumn].Text.ToString() == "")
                    return semn * -1;
                return semn * string.Compare(A.SubItems[CurrentColumn].Text.ToString(), B.SubItems[CurrentColumn].Text.ToString());
            }
        }

        public int Column
        {
            get
            {
                return Column;
            }

            set
            {
                CurrentColumn = value;
                if (LastSorted == CurrentColumn)
                    semn *= -1;
            }
        }

        public int Last
        {
            get
            {
                return LastSorted;
            }

            set
            {
                LastSorted = value;
            }
        }
    }
}
