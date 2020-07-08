using System;
using System.Collections.Generic;
using System.Text;

namespace AbstructFactoryPattern
{
    /// <summary>
    /// 为了隐藏具体的工厂类，客户端只需根据类型，拿到自己的工厂即可
    /// </summary>
    public class AbstructFruitFactory
    {
        /// <summary>
        /// 获取工厂实例
        /// </summary>
        /// <param name="factoryName"></param>
        /// <returns></returns>
        public static IAbstructFruit GetFactory(string factoryName)
        {
            IAbstructFruit factory;
            switch (factoryName)
            {
                case "BJ":
                    factory = new BJFactory();
                    break;
                case "GZ":
                    factory = new GZFactory();
                    break;
                default:
                    factory = null;
                    break;
            }
            return factory;

        }
    }
}
