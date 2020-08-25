using System;
using System.Collections.Generic;
using System.Text;

namespace VistorPattern
{
    public interface IDataStruct
    {
        void Accept(IVistor vistor);
    }
}
