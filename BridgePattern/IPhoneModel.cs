using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    /// <summary>
    /// 定义手机型号，使用不同的插件
    /// </summary>
    public interface IPhoneModel
    {
        /// <summary>
        /// 使用多大内存
        /// </summary>
        void UseRAM(string type);
    }
}
