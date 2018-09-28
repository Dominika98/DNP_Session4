using System;
using System.Threading.Tasks;

namespace Ex3_tasks_
{
    class Program
    {
        static void Main(string[] args)
        {
            Reader one=new Reader("Test.txt");
            Reader two=new Reader("notes.txt");
            Reader three=new Reader("Test2.txt");

            Parallel.Invoke(()=> one.Read(), ()=>two.Read(), ()=>three.Read());
            if(one.Data.Equals(two.Data))
                System.Console.WriteLine("The files are same");
            else
                System.Console.WriteLine("The files are not same");
            if(one.Data.Equals(three.Data))
                System.Console.WriteLine("The files are same");
            else
                System.Console.WriteLine("The files are not same");
        }
    }
}
