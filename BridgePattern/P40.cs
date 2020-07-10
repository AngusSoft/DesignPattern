using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    /// <summary>
    /// 实现具体的手机型号所用具体的RAM
    /// </summary>
    public class P40 : IPhoneModel
    {
        public void UseRAM(string type)
        {
            Console.WriteLine($"当前P40手机内存为{type}");
        }
    }
}
