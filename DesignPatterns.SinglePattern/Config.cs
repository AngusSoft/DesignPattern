using System;

namespace SinglePattern
{
    /// <summary>
    /// 静态类，优先加载
    /// </summary>
    public static class Config
    {
        /// <summary>
        /// 全局唯一实例（有的定义成volatile,感觉没太大必要，我自己没遇到过那种情况）
        /// </summary>
        private static Enterprise instance;

        /// <summary>
        /// 定义锁变量
        /// </summary>
        private static readonly object lockObj = new object();

        /// <summary>
        /// 获取实例
        /// </summary>
        /// <returns></returns>
        public static Enterprise GetInstance()
        {
            /* 
             * 因为如果没有这个判断的话，会有大量的线程对锁进行操作，影响读取实例的性能。
             */
            if(instance == null)
            {
                /*
                 * 每次只保证有一个线程在对实例进行操作。
                 */
                lock(lockObj)
                {
                    /*
                     * 如果没有这个判断的话，会重复创建其对象。(因为在对象被实例化之前，可能会有线程阻塞在锁那里等待锁释放)
                     */
                    if(instance == null)
                    {
                        instance = new Enterprise();
                    }
                }
            }
            return instance;
        }
    }
}
