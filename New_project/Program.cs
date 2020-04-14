using System;

namespace New_project
{
    struct point
    {
        public Int32 x,y;
        public point(Int32 _x)
        {
            this=new point();
            x=_x;
        }
    }
    class rectangle
    {
        public point lu,rd;
        public rectangle()
        {
            lu=new point();
            rd=new point();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            rectangle rectangle=new rectangle();
            System.Console.WriteLine(rectangle.lu.x.ToString()+rectangle.lu.y.ToString());
        }
    }
}
