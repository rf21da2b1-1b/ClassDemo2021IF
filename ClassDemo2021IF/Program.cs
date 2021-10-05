using System;

namespace ClassDemo2021IF
{
    class Program
    {
        static void Main(string[] args)
        {
            IFWorker worker = new IFWorker();
            worker.Start();


            Console.ReadLine();
        }
    }
}
