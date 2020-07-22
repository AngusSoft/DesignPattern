using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightPattern
{
    /// <summary>
    /// 不同车辆的种类，不要定义不同的类，要把它们当作是
    /// 内部状态的不同
    /// </summary>
    public class ConcreteCar : ICar
    {
        /// <summary>
        /// 不同种类的内部状态
        /// </summary>
        private string name { get; set; }

        public ConcreteCar(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// 实现获取单价
        /// </summary>
        public void GetPrice(double price)
        {
            Console.WriteLine($"{name}价值：{price}万元");
        }
    }
}
