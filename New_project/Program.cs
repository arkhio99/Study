using System;

namespace New_project
{
    delegate int function(int x);

    



    class Program
    {
        static int[] ArOfFunction(int[] x, function f)
    {
        int[] res=new int[x.Length];
        for(int i=0;i<x.Length;i++)
        {
            res[i]=f(x[i]);
        }
        return res;
    }
        static void Main(string[] args)
        {
            function f=delegate(int x)
            {
                return x*x;
            };
            int[] x=new int[10]
            {
                1,2,3,4,5,6,7,8,9,10
            };
            int[] sqrs=ArOfFunction(x,f);
            for(int i=0;i<sqrs.Length;i++)
            {
                System.Console.Write(sqrs[i].ToString()+" ");
            }
            System.Console.WriteLine("\n");
            int[] cubes=ArOfFunction(x,delegate(int x) 
            {
                return x*x*x;
            });
            for(int i=0;i<cubes.Length;i++)
            {
                System.Console.Write(cubes[i].ToString()+" ");
            }
        }
    }
}
