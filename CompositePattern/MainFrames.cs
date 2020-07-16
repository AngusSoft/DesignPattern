using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    /// <summary>
    /// 主机类
    /// </summary>
    public class MainFrames : Component
    {
        private List<Component> datas = new List<Component>();
        public MainFrames(string name)
            : base(name)
        {

        }

        public override void Make()
        {
            foreach(var item in datas)
            {
                item.Make();
            }
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="component"></param>
        public void Add(Component component)
        {
            datas.Add(component);
        }

        /// <summary>
        /// 移除
        /// </summary>
        /// <param name="component"></param>
        public void Remove(Component component)
        {
            datas.Remove(component);
        }
    }
}
