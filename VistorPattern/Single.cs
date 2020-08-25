using System;

namespace VistorPattern
{
    /// <summary>
    /// 单个
    /// </summary>
    public class Single : IDataStruct
    {
        public string Name { get; set; }

        public string Id { get; set; }

        public Single(string name, string id)
        {
            Name = name;
            Id = id;
        }

        public void Accept(IVistor vistor)
        {
            vistor.Visit(this);
        }
    }
}
