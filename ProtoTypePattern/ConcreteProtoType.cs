using System;
using System.Collections.Generic;
using System.Text;

namespace ProtoTypePattern
{
    /// <summary>
    /// 创建具体类型
    /// </summary>
    public class ConcreteProtoType : AppleProtoType
    {
        public ConcreteProtoType(string id, Tree allowTree)
            : base(id, allowTree)
        {

        }

        /// <summary>
        /// 浅拷贝苹果树
        /// </summary>
        /// <returns></returns>
        public override AppleProtoType Clone()
        {
            return (AppleProtoType)this.MemberwiseClone();
        }
    }
}
