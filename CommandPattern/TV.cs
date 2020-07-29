using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    /// <summary>
    /// 定义命令的接收者
    /// </summary>
    public class TV
    {
        public void On()
        {
            Console.WriteLine("打开电视");
        }

        public void Off()
        {
            Console.WriteLine("关闭电视");
        }
    }
}
