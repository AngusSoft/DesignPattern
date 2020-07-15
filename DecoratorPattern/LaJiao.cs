using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    /// <summary>
    /// 辣椒类
    /// </summary>
    public class LaJiao : Decorator
    {
        public LaJiao(INoodles noodles)
            : base(noodles)
        {

        }

        public override void AddSomeThing()
        {
            base.AddSomeThing();

            AddLaJiao();
        }

        public void AddLaJiao()
        {
            Console.WriteLine("这碗面条加了辣椒");
        }
    }
}
