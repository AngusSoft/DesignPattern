using System;
using System.Collections.Generic;
using System.Text;

namespace StragetyPattern
{
    /// <summary>
    /// 快速排序
    /// </summary>
    public class QuickSort : IArraySort
    {
        public void Sort(int[] array)
        {
            if(array.Length > 0)
            {
                Sort(array, 0, array.Length - 1);
            }
        }

        public void Sort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int index = GetIndex(array, left, right);
                Sort(array, left, index - 1);
                Sort(array, index + 1, right);
            }
                    
        }

        private int GetIndex(int[] array, int left, int right)
        {
            int source = array[left];
            while (left < right)
            {
                while (array[right] >= source && left < right)
                    right--;

                array[left] = array[right];

                while (array[left] <= source && left < right)
                    left++;

                array[right] = array[left];
            }

            array[left] = source;
            return left;
        }
    }
}
