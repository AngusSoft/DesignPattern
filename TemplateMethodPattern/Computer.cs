using System;

namespace TemplateMethodPattern
{
    /// <summary>
    /// 构建电脑模板类
    /// </summary>
    public abstract class Computer
    {
        /// <summary>
        /// 构建方法,定义流程
        /// </summary>
        public void Build()
        {
            Console.WriteLine("开始制作电脑");
            BuildScope();
            BuildMainFrame();
            BuildElectricSource();
            Console.WriteLine("电脑制作完成");
        }

        /// <summary>
        /// 自定义部分定义为抽象方法，构建显示器
        /// </summary>
        protected abstract void BuildScope();

        /// <summary>
        /// 自定义部分定义为抽象方法，构建主机
        /// </summary>
        protected abstract void BuildMainFrame();

        /// <summary>
        /// 自定义部分定义为抽象方法，构建电源
        /// </summary>
        protected abstract void BuildElectricSource();
    }
}
