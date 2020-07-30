using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    /// <summary>
    /// 定义订阅的主题抽象类
    /// </summary>
    public abstract class WeiXin
    {
        private List<IObserver> observers = new List<IObserver>();

        public string SystemInfo { get; set; }
        public WeiXin(string systemInfo)
        {
            SystemInfo = systemInfo;
        }

        /// <summary>
        /// 添加订阅者
        /// </summary>
        /// <param name="observer"></param>
        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        /// <summary>
        /// 移除订阅者
        /// </summary>
        /// <param name="observer"></param>
        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        /// <summary>
        /// 发布消息
        /// </summary>
        public void NotificationMsg()
        {
            foreach(var item in observers)
            {
                item.ReceiveMsg(this);
            }
        }
    }
}
