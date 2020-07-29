using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern
{
    /// <summary>
    /// 新增个性化子类，实现抽象方法
    /// </summary>
    public class ASUS : Computer
    {
        /// <summary>
        /// 构建电源
        /// </summary>
        protected override void BuildElectricSource()
        {
            Console.WriteLine("构建华硕电源");
        }

        /// <summary>
        /// 构建主机
        /// </summary>
        protected override void BuildMainFrame()
        {
            Console.WriteLine("构建华硕主机");
        }

        /// <summary>
        /// 构建显示器
        /// </summary>
        protected override void BuildScope()
        {
            Console.WriteLine("构建华硕显示器");
        }
    }
}
