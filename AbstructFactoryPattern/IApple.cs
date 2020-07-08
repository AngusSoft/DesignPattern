using System;
using System.Collections.Generic;
using System.Text;

namespace AbstructFactoryPattern
{
    /// <summary>
    /// 定义苹果接口，
    /// </summary>
    public interface IApple
    {
        /// <summary>
        /// 单价
        /// </summary>
        /// <returns></returns>
        decimal GetPrice();

        /// <summary>
        /// 包装形状
        /// </summary>
        /// <returns></returns>
        string GetPackageShape();
    }
}
