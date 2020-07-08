using System;
using SimpleFactoryPattern;

namespace Design.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleFactoryPatternMethods();
            Console.ReadKey();
        }

        /// <summary>
        /// 简单工厂方法
        /// </summary>
        public static void SimpleFactoryPatternMethods()
        {
            var apple = FruitFactory.CreateInstance("Apple");
            var banana = FruitFactory.CreateInstance("Banana");
            Console.WriteLine($"苹果单价是：{apple.GetPrice()}");
            Console.WriteLine($"香蕉单价是：{banana.GetPrice()}");
        }
    }
}
