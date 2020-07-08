using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    /// <summary>
    /// 水果工厂类
    /// </summary>
    public class FruitFactory
    {
        /// <summary>
        /// 创建实例
        /// </summary>
        /// <returns></returns>
        public static IFruit CreateInstance(string type)
        {
            IFruit instance;
            switch(type)
            {
                case "Apple":
                    instance = new Apple();
                    break;
                case "Banana":
                    instance = new Banana();
                    break;
                default:
                    instance = null;
                    break;
            }
            //这样返回的实例，调用对应的GetPrice方法，就会返回对应的单价
            return instance;
        }
    }
}
