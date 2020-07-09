using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    /// <summary>
    /// 北京建造者，实现IBuilder接口，实现自己的建造方法
    /// </summary>
    public class BJBuilder : IBuilder
    {
        private Cake bjCake = new Cake();

        /// <summary>
        /// 建造面包
        /// </summary>
        public void BuilderBread()
        {
            bjCake.Add(x => x.Bread = true);
            Console.WriteLine("北京面包制作完成");
        }

        /// <summary>
        /// 建造奶油
        /// </summary>
        public void BuilderCream()
        {
            bjCake.Add(x => x.Cream = true);
            Console.WriteLine("北京奶油制作完成");
        }

        /// <summary>
        /// 获取北京面包对象
        /// </summary>
        /// <returns></returns>
        public Cake GetCake()
        {
            bjCake.MakeCompleted();
            Console.WriteLine("北京蛋糕制作完成");
            return bjCake;
        }
    }
}
