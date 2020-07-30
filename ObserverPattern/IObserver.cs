using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    /// <summary>
    /// 抽象观察者接口
    /// </summary>
    public interface IObserver
    {
        /// <summary>
        /// 定义方法
        /// </summary>
        void ReceiveMsg(WeiXin weiXin);
    }
}
