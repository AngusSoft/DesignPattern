using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    /// <summary>
    /// 具体类
    /// </summary>
    public class ConcreteMediator : IMediator
    {
        private readonly Person WoMan;

        private readonly Person Man;

        public ConcreteMediator(Person woMan, Person man)
        {
            WoMan = woMan;
            Man = man;
        }

        public void WoManConnect()
        {
            WoMan.MySelfInfo();
        }

        public void ManConnect()
        {
            Man.MySelfInfo();
        }
    }
}
