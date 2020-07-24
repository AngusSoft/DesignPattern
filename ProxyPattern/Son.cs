using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    /// <summary>
    /// 代理购买角色
    /// </summary>
    public class Son : IPerson
    {
        // 实例化真实购买角色，其实这里依赖注入更好
        private Mom mom = new Mom();

        public void BuySoySauce()
        {
            ///可以执行其他方法
            Console.WriteLine("儿子：给我钱");
            mom.BuySoySauce();
            Console.WriteLine("儿子：酱油买来了");
        }
    }
}
