using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    /// <summary>
    /// 指挥者类，调用builder定义建造的流程
    /// </summary>
    public class Director
    {
        /// <summary>
        /// 构造蛋糕
        /// </summary>
        /// <param name="builder"></param>
        public void Construct(IBuilder builder)
        {
            builder.BuilderBread();
            builder.BuilderCream();
        }
    }
}
