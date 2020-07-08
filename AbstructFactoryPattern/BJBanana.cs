using System;
using System.Collections.Generic;
using System.Text;

namespace AbstructFactoryPattern
{
    /// <summary>
    /// 定义北京香蕉类
    /// </summary>
    public class BJBanana : IBanana
    {
        /// <summary>
        /// 定义北京香蕉包装形状
        /// </summary>
        /// <returns></returns>
        public string GetPackageShape()
        {
            // 意思到就行，别太在意啥形状。。。
            return "圆形";
        }

        /// <summary>
        /// 定义北京香蕉单价
        /// </summary>
        /// <returns></returns>
        public decimal GetPrice()
        {
            return (decimal)1.58;
        }
    }
}
