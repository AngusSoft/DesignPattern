using System;
using FactoryPattern;
using AbstructFactoryPattern;
using BuilderPattern;
using ProtoTypePattern;
using AdapterPattern;
using BridgePattern;
using DecoratorPattern;
using CompositePattern;
using FacadePattern;
using SimpleFactoryPattern;
using FlyweightPattern;
using ProxyPattern;
using TemplateMethodPattern;

namespace Design.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            //简单工厂模式
            //SimpleFactoryPatternMethods(); 

            //工厂方法模式
            //FactoryPatternMethods();

            //抽象工厂模式
            //AbstructFactoryPatternMethods();

            //建造者模式
            //BuilderPatternMethods();

            //原型模式
            //ProtoTypePatternMethods();

            //适配器模式
            //AdapterPatternMethods();

            //桥接模式
            //BridgePatternMethods();

            //装饰者模式
            //DecoratorPatternMethods();

            //组合模式
            //CompositePatternMethods();

            //外观模式
            //FacadePatternMethods();

            //享元模式
            //FlyweightPatternMethods();

            //代理模式
            //ProxyPatternMethods();

            //模板方法模式
            TemplateMethodPatternMethods();
            Console.ReadKey();
        }

        /// <summary>
        /// 简单工厂模式
        /// </summary>
        public static void SimpleFactoryPatternMethods()
        {
            var apple = FruitFactory.CreateInstance("Apple");
            var banana = FruitFactory.CreateInstance("Banana");
            Console.WriteLine($"苹果单价是：{apple.GetPrice()}");
            Console.WriteLine($"香蕉单价是：{banana.GetPrice()}");
        }

        /// <summary>
        /// 工厂方法模式
        /// </summary>
        public static void FactoryPatternMethods()
        {
            IFactory factory = new BJFruitFactory();
            IFruitProduct fruitProduct = factory.CreateInstance();
            fruitProduct.Make();
        }

        /// <summary>
        /// 抽象工厂模式
        /// </summary>
        public static void AbstructFactoryPatternMethods()
        {
            // 北京工厂
            var bjFactory = AbstructFruitFactory.GetFactory("BJ");
            var bjApple = bjFactory.GetApple();
            Console.WriteLine($"北京苹果的单价：{bjApple.GetPrice()}，包装形状：{bjApple.GetPackageShape()}");
            var bjBanana = bjFactory.GetBanana();
            Console.WriteLine($"北京香蕉的单价：{bjBanana.GetPrice()}，包装形状：{bjBanana.GetPackageShape()}");

            // 广州工厂
            var gzFactory = AbstructFruitFactory.GetFactory("GZ");
            var gzApple = gzFactory.GetApple();
            Console.WriteLine($"广州苹果的单价：{gzApple.GetPrice()}，包装形状：{gzApple.GetPackageShape()}");
            var gzBanana = gzFactory.GetBanana();
            Console.WriteLine($"广州香蕉的单价：{gzBanana.GetPrice()}， 包装形状：{gzBanana.GetPackageShape()}");
        }

        /// <summary>
        /// 建造者模式
        /// </summary>
        public static void BuilderPatternMethods()
        {
            var director = new Director();

            var bjBuilder = new BJBuilder();
            director.Construct(bjBuilder);
            bjBuilder.GetCake().Show();

            var gzBuilder = new GZBuilder();
            director.Construct(gzBuilder);
            gzBuilder.GetCake().Show();
        }

        /// <summary>
        /// 原型模式
        /// </summary>
        public static void ProtoTypePatternMethods()
        {
            var concreteType = new ConcreteProtoType("苹果A", new Tree
            {
                Name = "苹果树S"
            });

            ///注意：复杂类型，克隆的是引用，一个改变会跟随另一个改变
            ConcreteProtoType concreteType2 = (ConcreteProtoType)concreteType.Clone();
            concreteType2.Id = "苹果B";

            Console.WriteLine($"我是{concreteType.Id}我属于{concreteType.AllowTree.Name}");

            Console.WriteLine($"我是{concreteType2.Id}我属于{concreteType2.AllowTree.Name}");

        }

        /// <summary>
        /// 适配器模式
        /// </summary>
        public static void AdapterPatternMethods()
        {
            INikeShoesAdapter nikeShoes = new NikeShoesAdapter();
            nikeShoes.Nike();
        }

        /// <summary>
        /// 桥接模式
        /// </summary>
        public static void BridgePatternMethods()
        {
            //定义RAM类型
            var ram64 = new RAM64();
            //给桥接器定义其对手机型号
            ram64.PhoneModel = new Mate40();
            ram64.SetPhone();

            ram64.PhoneModel = new P40();
            ram64.SetPhone();

            var ram128 = new RAM128();
            ram128.PhoneModel = new Mate40();
            ram128.SetPhone();

            ram128.PhoneModel = new P40();
            ram128.SetPhone();
        }

        /// <summary>
        /// 装饰者模式
        /// </summary>
        public static void DecoratorPatternMethods()
        {
            var noodles = new YouPoNoodles();
            var egg = new Egg(noodles);
            var lajiao = new LaJiao(egg);
            lajiao.AddSomeThing();
        }

        /// <summary>
        /// 组合模式
        /// </summary>
        public static void CompositePatternMethods()
        {
            var mainFrames = new MainFrames("电脑主机");
            Console.WriteLine("开始构建电脑主机");
            var cpu = new CPU("CPU");
            var mainBoard = new MainBoard("主板");


            mainFrames.Add(cpu);
            mainFrames.Add(mainBoard);

            mainFrames.Make();
            Console.WriteLine("电脑主机构建完成");
        }

        /// <summary>
        /// 外观模式
        /// </summary>
        public static void FacadePatternMethods()
        {
            var facade = new Facade();
            facade.GetUserWhitVehicleInfo();
        }

        /// <summary>
        /// 享元模式
        /// </summary>
        public static void FlyweightPatternMethods()
        {
            //外部状态单价
            double price = 0;
            var factory = new CarFactory();

            var baoMa = factory.GetCar("宝马");
            price = 40;
            baoMa.GetPrice(price);

            var baoMaB = factory.GetCar("宝马");
            price = 30;
            baoMaB.GetPrice(price);

            var benChi = factory.GetCar("奔驰");
            price = 50;
            benChi.GetPrice(price);
        }

        /// <summary>
        /// 代理模式
        /// </summary>
        public static void ProxyPatternMethods()
        {
            IPerson person = new Son();
            person.BuySoySauce();
        }

        /// <summary>
        /// 模板方法模式
        /// </summary>
        public static void TemplateMethodPatternMethods()
        {
            Computer computer = new ASUS();
            computer.Build();
        }
    }
}
