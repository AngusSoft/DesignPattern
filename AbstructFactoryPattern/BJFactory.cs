using System;
using System.Collections.Generic;
using System.Text;

namespace AbstructFactoryPattern
{
    /// <summary>
    /// 定义北京水果工厂 
    /// </summary>
    public class BJFactory : IAbstructFruit
    {
        /// <summary>
        /// 获取北京苹果实例
        /// </summary>
        /// <returns></returns>
        public IApple GetApple()
        {
            return new BJApple();
        }

        /// <summary>
        /// 获取北京香蕉实例
        /// </summary>
        /// <returns></returns>
        public IBanana GetBanana()
        {
            return new BJBanana();
        }
    }
}
