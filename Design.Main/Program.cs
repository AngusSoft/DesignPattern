using System;
using FactoryPattern;

namespace Design.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryPatternMethods();
            Console.ReadKey();
        }

        /// <summary>
        /// 工厂方法模式
        /// </summary>
        public static void FactoryPatternMethods()
        {
            var apple = FruitFactory.CreateInstance("Apple");
            var banana = FruitFactory.CreateInstance("Banana");
            Console.WriteLine($"苹果单价是：{apple.GetPrice()}");
            Console.WriteLine($"香蕉单价是：{banana.GetPrice()}");
        }
    }
}
