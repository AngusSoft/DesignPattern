using System;
using System.Collections.Generic;
using System.Text;

namespace AbstructFactoryPattern
{
    /// <summary>
    /// 定义香蕉接口
    /// </summary>
    public interface IBanana
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
