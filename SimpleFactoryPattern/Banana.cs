using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattern
{
    /// <summary>
    /// 继承IGoods，方便转化
    /// </summary>
    public class Banana : IFruit
    {
        /// <summary>
        /// 香蕉单价
        /// </summary>
        /// <returns></returns>
        public decimal GetPrice()
        {
            return (decimal)1.2;
        }
    }
}
