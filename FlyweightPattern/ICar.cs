using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightPattern
{
    /// <summary>
    /// 定义享元接口，定义方法
    /// </summary>
    public interface ICar
    {
        /// <summary>
        /// 单价
        /// </summary>
        /// <param name="price"></param>
        void GetPrice(double price);
    }
}
