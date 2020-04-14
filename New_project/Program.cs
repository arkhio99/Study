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
        public static explicit operator A(B b)
        {
            return new A(b.i);
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
        /*public static explicit operator Int32(B b)
        {
            return b.ToInt32();
        }*/
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a=new A(3);
            B bFromAImp=a;
            A aFromB=(A)bFromAImp;
            B bFromAExp=(B)a;
            System.Console.WriteLine(bFromAImp.i);
            System.Console.WriteLine(aFromB.i);
            System.Console.WriteLine(bFromAExp.i);
        }
    }
}
