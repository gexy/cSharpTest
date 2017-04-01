using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//namespace cSharptest
//{
//    abstract class AbClass
//    {
//        public void IdentifyBase()
//        { Console.WriteLine("I am AbClass"); }
//        abstract public void IdentifyDerived();
//    }
//    class DerivedClass : AbClass
//    {
//        override public void IdentifyDerived()
//        { Console.WriteLine("I am DerivedClass"); }
//    }
//    class Program
//    {
//        static void Main()
//        {
//            DerivedClass b = new DerivedClass();
//            b.IdentifyBase();
//            b.IdentifyDerived();
//            Console.ReadKey();
//        }
//    }
//}
//namespace cSharpTest7_11_2
//{
//    abstract class MyBase
//    {
//        public int SideLength = 10;
//        const int TriangleSideConunt = 3;
//        abstract public void PrintStuff(string s);
//        abstract public int MyInt { get; set; }
//        public int PerimeterLength()
//        { return TriangleSideConunt * SideLength; }
//    }
//    class MyClass : MyBase
//    {
//        public override void PrintStuff(string s)
//        { Console.WriteLine(s); }
//        private int _myInt;
//        public override int MyInt
//        {
//            get{ return _myInt; }
//            set{ _myInt = value; }
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            MyClass mc = new MyClass();
//            mc.PrintStuff("This is a string.");
//            mc.MyInt = 28;
//            Console.WriteLine(mc.MyInt);
//            Console.WriteLine("Perimeter Length:{0}", mc.PerimeterLength());
//            Console.ReadKey();
//        }
//    }
//}
//namespace cSharpTest7_13
//{
//    static public class MyMath
//    {
//        public static float PI = 3.14f;
//        public static bool IsOdd(int x)
//        {
//            return x % 2 == 1;
//        }
//        public static int Times2(int x)
//        {
//            return 2 * x;
//        }
//    }
//    class Program
//    {
//        static void Main()
//        {
//            int val = 3;
//            Console.WriteLine("{0} is odd is {1}.", val, MyMath.IsOdd(val));
//            Console.WriteLine("{0} * 2 = {1}.", val, MyMath.Times2(val));
//            Console.ReadKey();
//        }
//    }
//}
//namespace cSharpTest7_14
//{
//    sealed class MyData
//    {
//        private double D1, D2, D3;
//        public MyData(double d1,double d2,double d3)
//        { D1 = d1; D2 = d2; D3 = d3; }
//        public double Sum() { return D1 + D2 + D3; }
//    }
//    static class ExtendMyData
//    {
//        public static double Averge(this MyData md)
//        {
//            return md.Sum() / 3;
//        }
//    }
//    class Program
//    {
//        static void Main()
//        {
//            MyData md = new MyData(3, 4, 5);
//            Console.WriteLine("Sum:{0}", md.Sum());
//            Console.WriteLine("Average:{0}", md.Averge());
//            Console.ReadKey();
//        }
//    }
//}
//namespace cSharpTest8_15
//{
//    class LimitedInt
//    {
//        const int MaxValue = 100;
//        const int MinValue = 10;

//        public static LimitedInt operator - (LimitedInt x)
//        {
//            LimitedInt li = new LimitedInt();
//            li.TheValue = 0;
//            return li;
//        }

//        public static LimitedInt operator - (LimitedInt x,LimitedInt y)
//        {
//            LimitedInt li = new LimitedInt();
//            li.TheValue = x.TheValue - y.TheValue;
//            return li;
//        }

//        public static LimitedInt operator + (LimitedInt x,double y)
//        {
//            LimitedInt li = new LimitedInt();
//            li.TheValue = x.TheValue + (int)y;
//            return li;
//        }

//        private int _theVlaue = 0;
//        public int TheValue
//        {
//            get { return _theVlaue; }
//            set
//            {
//                if (value < MinValue)
//                    _theVlaue = 0;
//                else
//                    _theVlaue = value > MaxValue
//                        ? MaxValue
//                        : value;
//            }
//        }
//    }
//    class Program
//    {
//        static void Main()
//        {
//            LimitedInt li1 = new LimitedInt();
//            LimitedInt li2 = new LimitedInt();
//            LimitedInt li3 = new LimitedInt();
//            li1.TheValue = 10; li2.TheValue = 26;
//            Console.WriteLine("li1:{0},li2:{1}", li1.TheValue, li2.TheValue);

//            li3 = -li1;
//            Console.WriteLine("-{0}={1}",li1.TheValue, li3.TheValue);

//            li3 = li2 - li1;
//            Console.WriteLine("{0}-{1}={2}", li2.TheValue, li1.TheValue, li3.TheValue);

//            li3 = li1 - li2;
//            Console.WriteLine("{0}-{1}={2}", li1.TheValue, li2.TheValue, li3.TheValue);
//            Console.ReadKey();
//        }
//    }
//}
//namespace cSarpTest9_6
//{
//    class program
//    {
//        static void Main()
//        {
//            int x = 3;
//            while (x > 0)
//            {
//                Console.WriteLine("x:{0}", x);
//                x--;
//            }
//            Console.WriteLine("Out of loop");
//            Console.ReadKey();
//        }
//    }
//}
//namespace cSarpTest9_7
//{
//    class program
//    {
//        static void Main()
//        {
//            int x = 0;
//            do
//                Console.WriteLine("x is {0}", x++);
//            while (x < 3);
//            Console.ReadKey();
//        }
//    }
//}
//namespace cSarpTest9_8
//{
//    class program
//    {
//        static void Main()
//        {
//            for (int i = 0; i < 3; i++)
//            {
//                Console.WriteLine("Inside loop.i:{0}", i);
//            }
//            Console.WriteLine("Out of Loop");
//            Console.ReadKey();
//        }
//    }
//}
//namespace cSarpTest9_9_1
//{
//    class program
//    {
//        static void Main()
//        {
//            for(int x = 1; x < 6; x++)
//            {
//                switch (x)
//                {
//                    case 2:
//                        Console.WriteLine("x is {0} -- In Case 2", x);
//                        break;
//                    case 5:
//                        Console.WriteLine("x is {0} -- In Case 5", x);
//                        break;
//                    default:
//                        Console.WriteLine("x is {0} -- In Default case", x);
//                        break;
//                }
//            }
//            Console.ReadKey();
//        }
//    }
//}
//namespace cSarpTest10_1
//{
//    struct Point
//    {
//        public int X;
//        public int Y;
//    }
//    class program
//    {
//        static void Main()
//        {
//            Point first, second, third;
//            first.X = 10; first.Y = 10;
//            second.X = 20; second.Y = 20;
//            third.X = first.X + second.X;
//            third.Y = first.Y + first.Y;
//            Console.WriteLine("first: {0},{1}", first.X, first.Y);
//            Console.WriteLine("second: {0},{1}", second.X, second.Y);
//            Console.WriteLine("third: {0},{1}", third.X, third.Y);

//            Console.ReadKey();
//        }
//    }
//}
namespace cSarpTest11_2
{
    [Flags]
    enum CardDeckSettings : uint
    {
        SingleDeck = 0x01,
        LargePictures = 0x02,
        FancyNumbers = 0x04,
        Animation = 0x08
    }
    class MyClass
    {
        bool UseSingleDeck = false,
             UseBigPics = false,
             UseFancyNumbers = false,
             UseAnimation = false,
             UseAnimationAndFancyNumbers = false;

        public void SetOptions(CardDeckSettings ops)
        {
            UseSingleDeck = ops.HasFlag(CardDeckSettings.SingleDeck);
            UseBigPics = ops.HasFlag(CardDeckSettings.LargePictures);
            UseFancyNumbers = ops.HasFlag(CardDeckSettings.FancyNumbers);
            UseAnimation = ops.HasFlag(CardDeckSettings.Animation);

            CardDeckSettings testFlags = CardDeckSettings.Animation | CardDeckSettings.FancyNumbers;
            UseAnimationAndFancyNumbers = ops.HasFlag(testFlags);
        }

        public void PrintOptions()
        {
            Console.WriteLine("Option settings:");
            Console.WriteLine("Use Single Deck                 -{0}", UseSingleDeck);
            Console.WriteLine("Use Large Pictures              -{0}", UseBigPics);
            Console.WriteLine("Use Fancy Numbers               -{0}", UseFancyNumbers);
            Console.WriteLine("Show Animation                  -{0}", UseAnimation);
            Console.WriteLine("Show Animation and FancyNumbers -{0}", UseAnimationAndFancyNumbers);
        }
    }
    class program
    {
        static void Main()
        {
            MyClass mc = new MyClass();
            CardDeckSettings ops = CardDeckSettings.SingleDeck | CardDeckSettings.FancyNumbers | CardDeckSettings.Animation;
            mc.SetOptions(ops);
            mc.PrintOptions();
            Console.ReadKey();
        }
    }
}


