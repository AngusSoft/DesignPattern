using System;
using System.Collections.Generic;
using System.Text;

namespace StragetyPattern
{
    public class SortOperation
    {
        private IArraySort arraySort;
        public SortOperation(IArraySort sort)
        {
            arraySort = sort;
        }

        public void Sort(int[] array)
        {
            arraySort.Sort(array);
            Console.WriteLine(string.Join(",", array));
        }
    }
}
