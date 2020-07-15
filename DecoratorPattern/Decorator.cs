using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    /// <summary>
    /// 必须是抽象类，并且继承自INoodles
    /// </summary>
    public abstract class Decorator : INoodles
    {
        private readonly INoodles _noodles;

        public Decorator(INoodles noodles)
        {
            _noodles = noodles;
        }

        /// <summary>
        /// 尽量搞成虚函数
        /// </summary>
        public virtual void AddSomeThing()
        {
            _noodles.AddSomeThing();
        }
    }
}
