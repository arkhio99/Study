using System;
using System.IO;
namespace New_project
{
    class AccountEventArgs:EventArgs
    {
        private readonly int _sum;
        private readonly string _op;
        public int Sum
        {
            get{
                return _sum;
            }
        }
        public string Operation
        {
            get{
                return _op;
            }
        }

        public AccountEventArgs(int s, string op)
        {
            _sum=s;
            _op=op;
        }
    }
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
        //public delegate void _notifyer(object sender, AccountEventArgs e);
        private event EventHandler<AccountEventArgs> n;
        public event EventHandler<AccountEventArgs> Notifyer{
            add
            {
                n+=new EventHandler<AccountEventArgs>(value);
                System.Console.WriteLine($"{value.Method.Name} added");
            }
            remove
            {
                n-=new EventHandler<AccountEventArgs>(value);
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
                n?.Invoke(this, new AccountEventArgs(delta,"Added"));
            }
            else
            {
                n?.Invoke(this, new AccountEventArgs(0,"Added"));
            }
        }
        public string[] GetRegisteredMethods()
        {
            Int32 l=n.GetInvocationList().Length;
            string[] ss=new string[l];
            for(int i=0;i<l;i++)
            {
                ss[i]=n.GetInvocationList()[i].Method.Name;
            }
            return ss;
        }
        public void Remove(int delta)
        {
            if(delta>0&&delta<=_sum)
            {
                _sum-=delta;
                n?.Invoke(this,new AccountEventArgs(delta,"Removed"));
            }
            else{
                n?.Invoke(this, new AccountEventArgs(0,"Remove"));
            }
        } 
        
    }    



    partial class Program
    {
        const string path="filemes.txt";
        static void DisplayMessage(object sender,AccountEventArgs e)
        {
            System.Console.WriteLine($"{e.Sum.ToString()} {e.Operation}");
        }
        static void FileMessage(object sender, AccountEventArgs e)
        {
            using(StreamWriter stream=new StreamWriter(path,append:true))
            {
                stream.WriteLine(
                    $"{e.Sum.ToString()} {e.Operation}"
                );
            }
            System.Console.WriteLine("File has updated");
        }
        static void Main(string[] args)
        {
            using(File.Create(path))
            {}
            Account acc=new Account("Andrew");
            acc.Notifyer+=DisplayMessage;
            acc.Add(30);
            acc.Remove(10);
            
            acc.Notifyer+=FileMessage;
            string[] ss=acc.GetRegisteredMethods();
            System.Console.WriteLine("\nMethods:");
            for(int i=0;i<ss.Length;i++)
            {
                System.Console.WriteLine(" "+ss[i]);
            }
            System.Console.WriteLine();
            
            acc.Add(-10);
            acc.Remove(30);
            acc.Notifyer-=DisplayMessage;
            acc.Notifyer-=FileMessage;
        }
    }
}
