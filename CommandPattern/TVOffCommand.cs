using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    /// <summary>
    /// 定义对象具体命令类
    /// </summary>
    public class TVOffCommand : ICommand
    {
        private readonly TV _tv;

        public TVOffCommand(TV tv)
        {
            _tv = tv;
        }

        /// <summary>
        /// 执行对应命令
        /// </summary>
        public void Action()
        {
            _tv.Off();
        }
    }
}
