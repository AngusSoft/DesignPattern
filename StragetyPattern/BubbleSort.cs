using System;
using System.Collections.Generic;
using System.Text;

namespace StragetyPattern
{
    /// <summary>
    /// 冒泡排序
    /// </summary>
    public class BubbleSort : IArraySort
    {
        public void Sort(int[] array)
        {
            for(var i = 0; i< array.Length; i++)
            {
                bool flag = false;
                for(var j = 0; j < array.Length - i - 1; j++)
                {
                    if(array[j] > array[j + 1])
                    {
                        var temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        flag = true;
                    }
                }
                if (!flag) break;
            }
        }
    }
}
