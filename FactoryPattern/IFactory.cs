using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    /// <summary>
    /// 抽象工厂类
    /// </summary>
    public interface IFactory
    {
        /// <summary>
        /// 定义公共方法
        /// </summary>
        /// <returns></returns>
        IFruitProduct CreateInstance();
    }
}
