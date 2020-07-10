using System;

namespace ProtoTypePattern
{
    /// <summary>
    /// 创建苹果抽象模型
    /// </summary>
    public abstract class AppleProtoType
    {
        /// <summary>
        /// 苹果Id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 苹果属于哪棵树
        /// </summary>
        public Tree AllowTree { get; set; }

        public AppleProtoType(string id, Tree allowTree)
        {
            this.Id = id;
            this.AllowTree = allowTree;
        }

        /// <summary>
        /// 定义抽象方法
        /// </summary>
        /// <returns></returns>
        public abstract AppleProtoType Clone();
    }

    /// <summary>
    /// 属于哪棵树下
    /// </summary>
    public class Tree
    {
        /// <summary>
        /// 树的名称
        /// </summary>
        public string Name { get; set; }
    }
}
