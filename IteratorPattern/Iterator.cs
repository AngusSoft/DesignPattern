using System;

namespace IteratorPattern
{
    public interface Iterator
    {
        bool MoveNext();

        object GetCurrent();

        void Next();

        void Reset();
    }
}
