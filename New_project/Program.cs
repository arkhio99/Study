using System;

namespace New_project
{
    public class A{
        public A()
        {
        }
        public void f()
        {
            System.Console.WriteLine("F from a");
            func();
        }
        public virtual void func()
        {
            System.Console.WriteLine("func from a");
        }
    }

    public class B:A{
        public B()
        {
        }
        public new void f()
        {
            System.Console.WriteLine("F from b");
            func();
            base.f();
        }
        public override void func()
        {
            System.Console.WriteLine("func from b");
        }
    }
    public class C:B{
        public C()
        {
        }
        public new void f()
        {
            System.Console.WriteLine("F from c");
            func();
            base.f();
        }
        public override void func()
        {
            System.Console.WriteLine("func from c");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            C c = new C();
            c.f();
        }
    }
}
