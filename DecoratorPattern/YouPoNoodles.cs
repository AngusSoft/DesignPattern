using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    /// <summary>
    /// 定义具体要被附加的类
    /// </summary>
    public class YouPoNoodles : INoodles
    {
        public void AddSomeThing()
        {
            Console.WriteLine("这碗面条没有加任何东西");
        }
    }
}
