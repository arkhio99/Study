using System;

namespace New_project
{
    sealed partial class A
    {
        partial void f(); 
        public Int32 SayHi()
        {
            f();
            return 0;
        }
    }
    sealed partial class A{
        partial void f()
        {
            System.Console.WriteLine("Hi");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            System.Console.WriteLine(a.SayHi());
        }
    }
}
