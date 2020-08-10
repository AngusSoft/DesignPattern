using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    /// <summary>
    /// 抽象中介者
    /// </summary>
    public interface IMediator
    {
        /// <summary>
        /// 定义中介者方法
        /// </summary>
        void WoManConnect();

        /// <summary>
        /// 定义中介者方法
        /// </summary>
        void ManConnect();
    }
}
