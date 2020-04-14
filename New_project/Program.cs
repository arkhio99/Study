using System;

namespace New_project
{
    internal class A{
        public Int32 i;
        public A(Int32 _i)
        {
            i=_i;
        }
    }
    
    internal static class AExtension
    {
        public static void SayHi(this A a)
        {
            //for(int i=0;i<a.i;i++)
            System.Console.WriteLine("Hi!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A a=new A(3);
            a.SayHi();
            A n=null;
            n.SayHi();
        }
    }
}
