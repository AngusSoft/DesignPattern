using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    public class MainBoard : Component
    {
        public MainBoard(string name)
            : base(name)
        {

        }

        public override void Make()
        {
            Console.WriteLine($"制造{Name}");
        }
    }
}
