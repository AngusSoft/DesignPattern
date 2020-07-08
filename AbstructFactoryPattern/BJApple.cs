using System;
using System.Collections.Generic;
using System.Text;

namespace AbstructFactoryPattern
{
    /// <summary>
    /// 定义北京苹果类
    /// </summary>
    public class BJApple : IApple
    {
        /// <summary>
        /// 获取北京苹果的包装
        /// </summary>
        /// <returns></returns>
        public string GetPackageShape()
        {
            return "圆形";
        }

        /// <summary>
        /// 北京苹果的单价
        /// </summary>
        /// <returns></returns>
        public decimal GetPrice()
        {
            return (decimal)1.1;
        }
    }
}
