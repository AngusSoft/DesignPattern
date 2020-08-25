using System;
using System.Collections.Generic;
using System.Text;

namespace VistorPattern
{
    /// <summary>
    /// 组
    /// </summary>
    public class Group : IDataStruct
    {
        public List<string> Names { get; set; }

        public Group(List<string> names)
        {
            Names = names;
        }

        public void Accept(IVistor vistor)
        {
            vistor.Visit(this);
        }
    }
}
