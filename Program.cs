﻿using System;
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
//namespace cSarpTest11_2
//{
//    [Flags]
//    enum CardDeckSettings : uint
//    {
//        SingleDeck = 0x01,
//        LargePictures = 0x02,
//        FancyNumbers = 0x04,
//        Animation = 0x08
//    }
//    class MyClass
//    {
//        bool UseSingleDeck = false,
//             UseBigPics = false,
//             UseFancyNumbers = false,
//             UseAnimation = false,
//             UseAnimationAndFancyNumbers = false;

//        public void SetOptions(CardDeckSettings ops)
//        {
//            UseSingleDeck = ops.HasFlag(CardDeckSettings.SingleDeck);
//            UseBigPics = ops.HasFlag(CardDeckSettings.LargePictures);
//            UseFancyNumbers = ops.HasFlag(CardDeckSettings.FancyNumbers);
//            UseAnimation = ops.HasFlag(CardDeckSettings.Animation);

//            CardDeckSettings testFlags = CardDeckSettings.Animation | CardDeckSettings.FancyNumbers;
//            UseAnimationAndFancyNumbers = ops.HasFlag(testFlags);
//        }

//        public void PrintOptions()
//        {
//            Console.WriteLine("Option settings:");
//            Console.WriteLine("Use Single Deck                 -{0}", UseSingleDeck);
//            Console.WriteLine("Use Large Pictures              -{0}", UseBigPics);
//            Console.WriteLine("Use Fancy Numbers               -{0}", UseFancyNumbers);
//            Console.WriteLine("Show Animation                  -{0}", UseAnimation);
//            Console.WriteLine("Show Animation and FancyNumbers -{0}", UseAnimationAndFancyNumbers);
//        }
//    }
//    class program
//    {
//        static void Main()
//        {
//            MyClass mc = new MyClass();
//            CardDeckSettings ops = CardDeckSettings.SingleDeck | CardDeckSettings.FancyNumbers | CardDeckSettings.Animation;
//            mc.SetOptions(ops);
//            mc.PrintOptions();
//            Console.ReadKey();
//        }
//    }
//}
//namespace cSarpTest12_7
//{
//    class program
//    {
//        static void Main()
//        {
//            int[] myIntArray = new int[4];
//            for(int i = 0; i < 4; i++)
//            {
//                myIntArray[i] = i * 10;
//            }
//            for(int i = 0; i < 4; i++)
//            {
//                Console.WriteLine("Value of element {0} = {1}", i, myIntArray[i]);
//            }
//            Console.ReadKey();
//        }
//    }
//}
//namespace cSarpTest12_8
//{
//    class program
//    {
//        static void Main()
//        {
//            int[][,] Arr;
//            Arr = new int[3][,];
//            Arr[0] = new int[,] { { 10, 20 }, { 100, 200 } };
//            Arr[1] = new int[,] { { 30, 40, 50 }, { 300, 400, 500 } };
//            Arr[2] = new int[,] { { 60, 70, 80, 90 }, { 600, 700, 800, 900 } };
//            for (int i = 0; i < Arr.GetLength(0); i++)
//            {
//                for (int j = 0; j < Arr[i].GetLength(0); j++)
//                {
//                    for (int k = 0; k < Arr[i].GetLength(1); k++)
//                    {
//                        Console.WriteLine("[{0}][{1},{2}] = {3}", i, j, k, Arr[i][j, k]);
//                    }
//                    Console.WriteLine("");
//                }
//                Console.WriteLine("");
//            }
//            Console.ReadKey();
//        }
//    }
//}
//namespace cSharpTest13_10
//{
//    delegate void PrintFunction();

//    class Test
//    {
//        public void Print1()
//        {
//            Console.WriteLine("Print1 -- instance");
//        }
//        public static void Print2()
//        {
//            Console.WriteLine("Print2 -- static");
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            Test t = new Test();
//            PrintFunction pf;

//            pf = t.Print1;
//            pf += Test.Print2;
//            pf += t.Print1;
//            pf += Test.Print2;

//            if (null != pf)
//                pf();
//            else
//                Console.WriteLine("Delegate is empty");
//            Console.ReadKey();
//        }
//    }
//}
//namespace cSharpTest13_11
//{
//    delegate int MyDel();
//    class MyClass
//    {
//        int IntValue = 5;
//        public int Add2() { IntValue += 2; return IntValue; }
//        public int Add3() { IntValue += 3; return IntValue; }
//    }
//    class Program
//    {
//        static void Main()
//        {
//            MyClass mc = new MyClass();
//            MyDel mDel = mc.Add2;
//            mDel += mc.Add3;
//            mDel += mc.Add2;
//            Console.WriteLine("Value:{0}", mDel());
//            Console.ReadKey();
//        }
//    }
//}
//namespace cSharpTest13_12
//{
//    delegate void MyDel(ref int X);
//    class MyClass
//    {
//        public void Add2(ref int x) { x += 2; }
//        public void Add3(ref int x) { x += 3; }
//        static void Main()
//        {
//            MyClass mc = new MyClass();
//            MyDel mDel = mc.Add2;
//            mDel += mc.Add3;
//            mDel += mc.Add2;
//            int x = 5;
//            mDel(ref x);
//            Console.WriteLine("Value:{0}", x);
//            Console.ReadKey();
//        }
//    }
//}
//namespace cSharpTest13_13
//{
//    class Progeam
//    {
//        delegate int OtherDel(int InParam);
//        static void Main()
//        {
//            OtherDel del = delegate (int x)
//              {
//                  return x + 20;
//              };
//            Console.WriteLine("{0}", del(5));
//            Console.WriteLine("{0}", del(6));
//            Console.ReadKey();
//        }
//    }
//}
//namespace cSharpTest13_14
//{
//    delegate double MyDel(int par);

//    class Program
//    {
//        static void Main()
//        {
//            MyDel del = delegate (int x) { return x + 1; };
//            MyDel le1 = (int x) => { return x + 1; };
//            MyDel le2 = (x) => { return x + 1; };
//            MyDel le3 = x => { return x + 1; };
//            MyDel le4 = x => x + 1;

//            Console.WriteLine("{0}", del(12));
//            Console.WriteLine("{0}", le1(12));
//            Console.WriteLine("{0}", le2(12));
//            Console.WriteLine("{0}", le3(12));
//            Console.WriteLine("{0}", le4(12));
//            Console.ReadKey();
//        }
//    }
//}
//namespace cSharpTest14_5
//{
//    delegate void Handler();
//    class Incrementer
//    {
//        public event Handler CountedADozen;

//        public void DoCount()
//        {
//            for (int i = 1; i < 100; i++)
//                if (i % 12 == 0 && CountedADozen != null)
//                    CountedADozen();
//        } 
//    }
//    class Dozens
//    {
//        public int DozensCount { get; private set; }

//        public Dozens(Incrementer incrementer)
//        {
//            DozensCount = 0;
//            incrementer.CountedADozen += IncrementDozensCount;
//        }

//        void IncrementDozensCount()
//        {
//            DozensCount++;
//        }
//    }
//    class Program
//    {
//        static void Main()
//        {
//            Incrementer incrementer = new Incrementer();
//            Dozens dozensCounter = new Dozens(incrementer);

//            incrementer.DoCount();
//            Console.WriteLine("Number of dozens = {0}", dozensCounter.DozensCount);
//            Console.ReadKey();
//        }
//    }
//}
//namespace cSharpTest14_6
//{
//    class Incrementer
//    {
//        public event EventHandler CountedADozen;

//        public void DoCount()
//        {
//            for (int i = 1; i < 100; i++)
//                if (i % 12 == 0 && CountedADozen != null)
//                    CountedADozen(this, null);
//        }
//    }
//    class Dozens
//    {
//        public int DozensCount { get; private set; }

//        public Dozens(Incrementer incrementer)
//        {
//            DozensCount = 0;
//            incrementer.CountedADozen += IncrementDozensCount;
//        }

//        void IncrementDozensCount(object source, EventArgs e)
//        {
//            DozensCount++;
//        }
//    }
//    class Program
//    {
//        static void Main()
//        {
//            Incrementer incrementer = new Incrementer();
//            Dozens dozensCounter = new Dozens(incrementer);
//            incrementer.DoCount();
//            Console.WriteLine("Number of dozens = {0}", dozensCounter.DozensCount);
//            Console.ReadKey();
//        }
//    }
//}
//namespace cSharpTest14_6_1
//{
//    public class IncrementerEventArgs : EventArgs
//    {
//        public int IntertionCount { get; set; } 
//    }

//    class Incrementer
//    {
//        public event EventHandler<IncrementerEventArgs> CountedAdozen;

//        public void DoCount()
//        {
//            IncrementerEventArgs args = new IncrementerEventArgs();
//            for (int i = 1; i < 100; i++)
//                if (i % 12 == 0 && CountedAdozen != null)
//                {
//                    args.IntertionCount = i;
//                    CountedAdozen(this, args);
//                }
//        }
//    }
//    class Dozens
//    {
//        public int DozensCount { get; private set; }

//        public Dozens(Incrementer incrementer)
//        {
//            DozensCount = 0;
//            incrementer.CountedAdozen += IncrementDozensCount;
//        }
//        void IncrementDozensCount(object source, IncrementerEventArgs e)
//        {
//            Console.WriteLine("Incremented at iteration:{0} in {1}", e.IntertionCount, source.ToString());
//            DozensCount++;
//        }
//    }
//    class Program
//    {
//        static void Main()
//        {
//            Incrementer incrementer = new Incrementer();
//            Dozens dozensCounter = new Dozens(incrementer);

//            incrementer.DoCount();
//            Console.WriteLine("Number of dozens = {0}", dozensCounter.DozensCount);
//        }
//    }
//}
//namespace cSharpTest14_6_2
//{
//    class Publisher
//    {
//        public event EventHandler SimpleEvent;
//        public void RaiseTheEvent() { SimpleEvent(this, null); }
//    }
//    class Subsvriber
//    {
//        public void MethodA(object o, EventArgs e) { Console.WriteLine("AAA"); }
//        public void MethodB(object o, EventArgs e) { Console.WriteLine("BBB"); }
//    }
//    class Program
//    {
//        static void Main()
//        {
//            Publisher p = new Publisher();
//            Subsvriber s = new Subsvriber();

//            p.SimpleEvent += s.MethodA;
//            p.SimpleEvent += s.MethodB;
//            p.RaiseTheEvent();

//            Console.WriteLine("\r\nRemove MethodB");
//            p.SimpleEvent -= s.MethodB;
//            p.RaiseTheEvent();
//        }
//    }
//}
//namespace cSharpTest15_1_1
//{
//    interface IInfo
//    {
//        string GetName();
//        string GetAge();
//    }

//    class CA : IInfo
//    {
//        public string Name;
//        public int Age;
//        public string GetName() { return Name; }
//        public string GetAge() { return Age.ToString(); }
//    }

//    class CB : IInfo
//    {
//        public string First;
//        public string Last;
//        public double PersonsAge;
//        public string GetName() { return First + " " + Last; }
//        public string GetAge() { return PersonsAge.ToString(); }
//    }

//    class Program
//    {
//        static void PrintInfo(IInfo item)
//        {
//            Console.WriteLine("Name:{0},Age {1}", item.GetName(), item.GetAge());
//        }

//        static void Main()
//        {
//            CA a = new CA() { Name = "John Doe", Age = 35 };
//            CB b = new CB() { First = "Jane", Last = "Doe", PersonsAge = 33 };

//            PrintInfo(a);
//            PrintInfo(b);
//        }
//    }
//}
//namespace cSharpTest15_1_2
//{
//    class MyClass : IComparable
//    {
//        public int TheValue;
//        public int CompareTo(object obj)
//        {
//            MyClass mc = (MyClass)obj;
//            if (this.TheValue < mc.TheValue) return -1;
//            if (this.TheValue > mc.TheValue) return 1;
//            return 0;
//        }
//    }
//    class Program
//    {
//        static void PrintOut(string s, MyClass[] mc)
//        {
//            Console.Write(s);
//            foreach (var m in mc)
//                Console.Write("{0} ", m.TheValue);
//            Console.WriteLine("");
//        }
//        static void Main()
//        {
//            var myInt = new[] { 20, 4, 16, 9, 2 };
//            MyClass[] mcArr = new MyClass[5];
//            for (int i = 0; i < 5; i++)
//            {
//                mcArr[i] = new MyClass();
//                mcArr[i].TheValue = myInt[i];
//            }
//            PrintOut("Initial Order: ", mcArr);
//            Array.Sort(mcArr);
//            PrintOut("Sorted Order: ", mcArr);
//        }
//    }
//}
//namespace cSharpTest15_3
//{
//    interface IIfc1
//    {
//        void PrintOut(string s);
//    }
//    class MyClass : IIfc1
//    {
//        public void PrintOut(string s)
//        {
//            Console.WriteLine("Calling through: {0}", s);
//        }
//    }
//    class Program
//    {
//        static void Main()
//        {
//            MyClass mc = new MyClass();
//            mc.PrintOut("object");
//        }
//    }
//}
//namespace cSharpTest15_4
//{
//    interface IIfc1
//    {
//        void PrintOut(string s);
//    }
//    class MyClass : IIfc1
//    {
//        public void PrintOut(string s)
//        {
//            Console.WriteLine("Calling through: {0}", s);
//        }
//    }
//    class Program
//    {
//        static void Main()
//        {
//            MyClass mc = new MyClass();
//            mc.PrintOut("object");
//            IIfc1 ifc = (IIfc1)mc;
//            ifc.PrintOut("interface");
//        }
//    }
//}
namespace cSharpTest15_6
{
    interface IDataRetrieve { int GetData(); }
    interface IDataStore { void SetData(int x); }
    class MyData : IDataRetrieve, IDataStore
    {
        int Mem1;
        public int GetData() { return Mem1; }
        public void SetData(int x) { Mem1 = x; }
    }
    class Program
    {
        static void Main()
        {
            MyData data = new MyData();
            data.SetData(5);
            Console.WriteLine("value = {0}", data.GetData());
        }
    }
}
