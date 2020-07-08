using System;
using System.Collections.Generic;
using System.Text;

namespace AbstructFactoryPattern
{
    /// <summary>
    /// 定义广州苹果类
    /// </summary>
    public class GZApple : IApple
    {
        /// <summary>
        /// 广州苹果包装
        /// </summary>
        /// <returns></returns>
        public string GetPackageShape()
        {
            return "方形";
        }

        /// <summary>
        /// 广州苹果单价
        /// </summary>
        /// <returns></returns>
        public decimal GetPrice()
        {
            return (decimal)0.50;
        }
    }
}
