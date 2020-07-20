using System;

namespace FactoryPattern
{
    /// <summary>
    /// 继IFruitProduct,具体实现
    /// </summary>
    public class Orange : IFruitProduct
    {
        /// <summary>
        /// 对方法进行具体实现
        /// </summary>
        public void Make()
        {
            Console.WriteLine("制作了一个橘子");
        }
    }
}
