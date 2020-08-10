using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    /// <summary>
    /// 抽象人
    /// </summary>
    public abstract class Person
    {
        protected string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        /// <summary>
        /// 定义抽象方法
        /// </summary>
        public abstract void MySelfInfo();
    }
}
