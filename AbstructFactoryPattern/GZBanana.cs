using System;
using System.Collections.Generic;
using System.Text;

namespace AbstructFactoryPattern
{
    /// <summary>
    /// 定义广州香蕉
    /// </summary>
    public class GZBanana : IBanana
    {
        /// <summary>
        /// 广州香蕉的包装
        /// </summary>
        /// <returns></returns>
        public string GetPackageShape()
        {
            return "方形";
        }

        /// <summary>
        /// 广州香蕉单价
        /// </summary>
        /// <returns></returns>
        public decimal GetPrice()
        {
            return (decimal)0.25;
        }
    }
}
