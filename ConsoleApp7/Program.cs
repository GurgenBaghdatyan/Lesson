using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Counter a = new Counter();
            Counter b = new Counter();
            a.Value = 6;
            b.Value = 7;
            Counter c = new Counter();
            c = a + b;
            Console.WriteLine(c.Value);
            Console.ReadKey();
        }
    }
    public class Car
    {
        public virtual string Name() { return "car"; }
        public virtual double Speed() { return 100; }
        public virtual int HorstPower() { return 0; }
        public virtual double Age() { return 54; }
    }
    public class BMW : Car
    {
        public override string Name() { return "BMW"; }
        public override double Speed() { return 250; }
        public override int HorstPower() { return 750; }
        public override double Age() { return 10; }
    }
    public class Mercedes : Car
    {
        public override string Name() { return "Mercedes"; }
        public override double Speed() { return 200; }
        public override int HorstPower() { return 700; }
        public override double Age() { return 20; }
    }



}
