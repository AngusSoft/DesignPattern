using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Concurrent;

namespace FlyweightPattern
{
    /// <summary>
    /// 定义享元工厂类，管理享元对象
    /// </summary>
    public class CarFactory
    {
        /// <summary>
        /// 定义内部集合，管理具体享元
        /// </summary>
        private readonly ConcurrentDictionary<string, ICar> dataDic = new ConcurrentDictionary<string, ICar>();

        /// <summary>
        /// 获取享元对象
        /// </summary>
        /// <returns></returns>
        public ICar GetCar(string carName)
        {
            var data = dataDic.GetOrAdd(carName, carName =>
            {
                return new ConcreteCar(carName);
            });

            return data;
        }
    }
}
