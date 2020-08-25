using System;
using System.Collections.Generic;
using System.Text;

namespace VistorPattern
{
    public interface IVistor
    {
        /// <summary>
        /// 访问组
        /// </summary>
        /// <param name="group"></param>
        void Visit(IDataStruct group);
    }
}
