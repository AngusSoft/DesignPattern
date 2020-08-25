using System;
using System.Collections.Generic;
using System.Text;

namespace VistorPattern
{
    public class PrintVisit : IVistor
    {
        public void Visit(IDataStruct dataStruct)
        {
            Print(dataStruct);
        }

        private void Print<T>(T model)
        {
            if(model is Group group)
            {
                Console.WriteLine($"打印：{string.Join(',', group.Names)}");
            }
            else if(model is Single single)
            {
                Console.WriteLine($"打印：{single.Name}");
            }
        }
    }
}
