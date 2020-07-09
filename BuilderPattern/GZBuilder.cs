using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    /// <summary>
    /// 广州蛋糕制作类，继承IBuilder，实现自己的建造方法
    /// </summary>
    public class GZBuilder : IBuilder
    {
        /// <summary>
        /// 定义广州蛋糕对象
        /// </summary>
        private Cake gzCake = new Cake();

        /// <summary>
        /// 制作广州面包
        /// </summary>
        public void BuilderBread()
        {
            gzCake.Add(x => x.Bread = true);
            Console.WriteLine("广州面包制作完成");
        }
        
        /// <summary>
        /// 制作广州奶油
        /// </summary>
        public void BuilderCream()
        {
            gzCake.Add(x => x.Cream = true);
            Console.WriteLine("广州奶油制作完成");
        }

        /// <summary>
        /// 获取广州蛋糕对象
        /// </summary>
        /// <returns></returns>
        public Cake GetCake()
        {
            gzCake.MakeCompleted();
            Console.WriteLine("广州蛋糕制作完成");
            return gzCake;
        }
    }
}
