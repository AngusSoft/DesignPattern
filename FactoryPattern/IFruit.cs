using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    /// <summary>
    /// 也可以定义成抽象类，看自己习惯
    /// </summary>
    public interface IFruit
    {
        /// <summary>
        /// 接口现在可以有默认实现了。继承的接口类，不需要强制实现接口
        /// </summary>
        /// <returns></returns>
        decimal GetPrice()
        {
            return (decimal)1.1;
        }
    }
}
