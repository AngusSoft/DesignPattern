using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    /// <summary>
    /// 定义对象具体命令类
    /// </summary>
    public class TVOnCommand : ICommand
    {
        private readonly TV _tv;

        public TVOnCommand(TV tv)
        {
            _tv = tv;
        }

        /// <summary>
        /// 调用对应方法
        /// </summary>
        public void Action()
        {
            _tv.On();
        }
    }
}
