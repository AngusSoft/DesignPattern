using System;

namespace BridgePattern
{
    /// <summary>
    /// 实现具体的手机型号所用具体的RAM
    /// </summary>
    public class Mate40 : IPhoneModel
    {
        public void UseRAM(string type)
        {
            Console.WriteLine($"当前Mate40的内存为{type}");
        }
    }
}
