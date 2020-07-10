using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    /// <summary>
    /// 继承RAM，实现抽象方法，并在里面通过桥接器，
    /// 调用对应的方法
    /// </summary>
    public class RAM64 : RAM
    {
        public override void SetPhone()
        {
            PhoneModel.UseRAM("64G");
        }
    }
}
