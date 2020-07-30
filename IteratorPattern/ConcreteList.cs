using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    public class ConcreteList : IListCollection
    {
        int[] collection;

        public ConcreteList()
        {
            collection = new int[] { 1, 2, 3, 6 };
        }
        public Iterator GetIterator()
        {
            return new ConcreteIterator(this);
        }

        public int Length
        {
            get
            {
                return collection.Length;
            }
        }

        public int GetElement(int index)
        {
            return collection[index];
        }


    }
}
