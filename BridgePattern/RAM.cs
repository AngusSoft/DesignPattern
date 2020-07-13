using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    /// <summary>
    /// 必须定义为抽象类，不能定义为接口，因为接口里面不能包含字段
    /// 这个字段起始就算是桥接器，把两个抽象给连接了起来
    /// </summary>
    public abstract class RAM
    {
        /// <summary>
        /// 这个就相当于桥接器了
        /// </summary>
        public IPhoneModel PhoneModel { get; set; }

        /// <summary>
        /// 定义抽象方法，供不同的RAM扩展
        /// </summary>
        public abstract void SetPhone();
    }
}
