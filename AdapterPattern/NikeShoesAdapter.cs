using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    /// <summary>
    /// 定义nick适配角色
    /// </summary>
    public class NikeShoesAdapter : INikeShoesAdapter
    {
        /// <summary>
        /// 内部需要创建原始对象
        /// </summary>
        private PuTianShoes puTianShoes = new PuTianShoes();
        
        /// <summary>
        /// 实现nike方法
        /// </summary>
        public void Nike()
        {
            puTianShoes.PuTian();
        }
    }
}
