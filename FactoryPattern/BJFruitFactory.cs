using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    /// <summary>
    /// 水果工厂类
    /// </summary>
    public class BJFruitFactory : IFactory
    {
        public IFruitProduct CreateInstance()
        {
            return new Orange();
        }
    }
}
