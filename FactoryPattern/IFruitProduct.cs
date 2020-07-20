using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    /// <summary>
    /// 抽象水果产品类
    /// </summary>
    public interface IFruitProduct
    {
        /// <summary>
        /// 定义公共方法
        /// </summary>
        void Make();
    }
}
