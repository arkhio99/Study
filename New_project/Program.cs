using System;

namespace New_project
{
    class A
    {
        int i=0;
        public int I
        {
            get{
                return i;
            }
        }
        public A(int _i)
        {
            i=_i;
        }
        public static implicit operator A(B b)
        {
            return new A(b.i);
        } 
    }
    class B{
        public int i=1;
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a= (A)(new B());
            System.Console.WriteLine(a.I);
        }
    }
}
