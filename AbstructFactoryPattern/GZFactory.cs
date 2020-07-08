using System;
using System.Collections.Generic;
using System.Text;

namespace AbstructFactoryPattern
{
    /// <summary>
    /// 广州工厂类
    /// </summary>
    public class GZFactory : IAbstructFruit
    {
        /// <summary>
        /// 获取广州苹果实例
        /// </summary>
        /// <returns></returns>
        public IApple GetApple()
        {
            return new GZApple();
        }

        /// <summary>
        /// 获取广州香蕉实例
        /// </summary>
        /// <returns></returns>
        public IBanana GetBanana()
        {
            return new GZBanana();
        }
    }
}
