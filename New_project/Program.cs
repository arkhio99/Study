using System;

namespace New_project
{
    public class A
    {
        int i;
        public A(int a)
        {
            i=a;
        }
        public int geti()
        {
            return 5;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Object o= new Object();
            A a=(A)o;
            System.Console.WriteLine(a.geti());
        }
    }
}
