using System;

namespace New_project
{
    class Account
    {
        private int _sum;
        private readonly string _name;
        public int Sum{
            get
            {
                return _sum;
            }
        }
        public string Name{
            get{
                return _name;
            }
        }
        public delegate void _notifyer(string s);
        private event _notifyer n;
        public event _notifyer Notifyer{
            add
            {
                n+=new _notifyer(value);
                System.Console.WriteLine($"{value.Method.Name} added");
            }
            remove
            {
                n-=new _notifyer(value);
                System.Console.WriteLine($"{value.Method.Name} removed");
            }
        }
        public Account(string n)
        {
            _name=n;
            _sum=0;
        }
        public void Add(int delta)
        {
            if(delta>0)
            {
                _sum+=delta;
                n?.Invoke($"Added {delta}$");
            }
            else
            {
                n?.Invoke("Sum is under 0");
            }
        }
        public void Remove(int delta)
        {
            if(delta>0&&delta<=_sum)
            {
                _sum-=delta;
                n?.Invoke($"Removed {delta}$");
            }
            else{
                n?.Invoke("Impossible");
            }
        } 
        
    }    



    class Program
    {
        static void ShowMes(string s)
        {
            System.Console.WriteLine(s);
        }
        static void Main(string[] args)
        {
            Account acc=new Account("Andrew");
            acc.Notifyer+=ShowMes;
            acc.Add(30);
            acc.Remove(10);
            acc.Add(-10);
            acc.Remove(30);
            acc.Notifyer-=ShowMes;
        }
    }
}
