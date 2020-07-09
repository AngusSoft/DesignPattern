using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    /// <summary>
    /// 抽象建造者，这里也可以用抽象类，定义可以建造那些东西
    /// </summary>
    public interface IBuilder
    {
        /// <summary>
        /// 制作面包
        /// </summary>
        void BuilderBread();

        /// <summary>
        /// 制作奶油
        /// </summary>
        void BuilderCream();

        /// <summary>
        /// 获取蛋糕对象
        /// </summary>
        /// <returns></returns>
        Cake GetCake();
    }
}
