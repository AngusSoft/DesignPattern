using System;

namespace BuilderPattern
{
    /// <summary>
    /// 定义最终实现的产品
    /// </summary>
    public class Cake
    {
        /// <summary>
        /// 面包
        /// </summary>
        public bool Bread { get; set; }

        /// <summary>
        /// 奶油
        /// </summary>
        public bool Cream { get; set; }

        /// <summary>
        /// 是否制作完成
        /// </summary>
        private bool IsMakeComplete { get; set; }

        /// <summary>
        /// 添加东西
        /// </summary>
        /// <param name="action"></param>
        public void Add(Action<Cake> action)
        {
            action.Invoke(this);
        }

        /// <summary>
        /// 制作完成
        /// </summary>
        public void MakeCompleted()
        {
            IsMakeComplete = true;
        }

        /// <summary>
        /// 展示实现的产品
        /// </summary>
        public void Show()
        {
            if(IsMakeComplete)
            {
                Console.WriteLine("蛋糕制作完成!"); 
            }
            else
            {
                Console.WriteLine("蛋糕制作失败");
            }
        }
    }
}
