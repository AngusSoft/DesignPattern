using System;

namespace FactoryPattern
{
    /// <summary>
    /// 继IGoods，方便转化
    /// </summary>
    public class Apple : IFruit
    {
        /// <summary>
        /// 苹果单价
        /// </summary>
        /// <returns></returns>
        public decimal GetPrice()
        {
            return (decimal)1.3;
        }
    }
}
