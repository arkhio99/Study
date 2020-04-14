using System;

namespace New_project
{
    class A{
        public Int32 i;
        public A(Int32 _i)
        {
            i=_i;
        }
        public B ToB()
        {
            return new B(i);
        }
    }
    class B
    {
        public Int32 i;
        internal B(Int32 _i)
        {
            i=_i;
        }
        public B(A a)
        {
            i=a.i;
        }
        public Int32 ToInt32()
        {
            return i;
        }
        public static implicit operator B(A a)
        {
            return new B(a);
        }
        public static explicit operator Int32(B b)
        {
            return b.ToInt32();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a=new A(3);
            B b=a;
            Int32 i=(Int32)b;
            System.Console.WriteLine(b.i);
            System.Console.WriteLine(i);
        }
    }
}
