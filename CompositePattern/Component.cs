using System;

namespace CompositePattern
{
    /// <summary>
    /// 抽象基本构造类
    /// </summary>
    public abstract class Component
    {
        protected string Name { get; set; }

        public Component(string name)
        {
            Name = name;
        }
        
        /// <summary>
        /// 定义制造的抽象方法
        /// </summary>
        public abstract void Make();
    }
}
