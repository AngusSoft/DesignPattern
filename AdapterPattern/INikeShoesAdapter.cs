using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    /// <summary>
    /// 定义目标接口，即客户端需要的接口
    /// </summary>
    public interface INikeShoesAdapter
    {
        /// <summary>
        /// nike鞋子
        /// </summary>
        void Nike();
    }
}
