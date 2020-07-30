using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class GameObserver : IObserver
    {
        private string _name { get; set; }

        public GameObserver(string name)
        {
            _name = name;
        }

        public void ReceiveMsg(WeiXin weiXin)
        {
            Console.WriteLine($"通知{_name}：{weiXin.SystemInfo}");
        }
    }
}
