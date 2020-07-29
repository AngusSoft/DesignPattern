using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    /// <summary>
    /// 传递方，负责调用命令
    /// </summary>
    public class Invoke
    {
        public ICommand command { get; set; }

        /// <summary>
        /// 执行指定命令
        /// </summary>
        public void ExcuteCommand()
        {
            command.Action();
        }
    }
}
