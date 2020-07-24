using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    /// <summary>
    /// 真实购买角色
    /// </summary>
    public class Mom : IPerson
    {
        public void BuySoySauce()
        {
            Console.WriteLine("妈妈：去给我买瓶酱油");
        }
    }
}
