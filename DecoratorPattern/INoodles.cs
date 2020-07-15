using System;

namespace DecoratorPattern
{
    /// <summary>
    /// 定义面条的规范，也可以定义为抽象类
    /// </summary>
    public interface INoodles
    {
        /// <summary>
        /// 添加一些东西
        /// </summary>
        void AddSomeThing();
    }
}
