using System;

namespace AbstructFactoryPattern
{
    /// <summary>
    /// 定义抽象水果接口
    /// </summary>
    public interface IAbstructFruit
    {
        /// <summary>
        /// 苹果
        /// </summary>
        /// <returns></returns>
        IApple GetApple();

        /// <summary>
        /// 香蕉
        /// </summary>
        /// <returns></returns>
        IBanana GetBanana();
    }
}
