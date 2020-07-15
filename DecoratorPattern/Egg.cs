using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    /// <summary>
    /// 卤蛋类
    /// </summary>
    public class Egg : Decorator
    {
        /// <summary>
        /// 构造函数将noodles传递给父类，使父类用同一个对象
        /// </summary>
        /// <param name="noodles"></param>
        public Egg(INoodles noodles)
            :base(noodles)
        {
            
        }

        public override void AddSomeThing()
        {
            //先执行父类方法
            base.AddSomeThing();

            AddEgg();
        }

        /// <summary>
        /// 添加卤蛋
        /// </summary>
        public void AddEgg()
        {
            Console.WriteLine("这碗面条加了卤蛋了");
        }
    }
}
