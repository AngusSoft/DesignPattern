using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    /// <summary>
    /// cpu类
    /// </summary>
    public class CPU : Component
    {
        public CPU(string name)
            : base(name)
        {

        }

        public override void Make()
        {
            Console.WriteLine($"制造{Name}");
        }
    }
}
