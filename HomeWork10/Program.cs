using System;

namespace HomeWork10
{
    internal class Program
    {
    static void Main(string[] args)
        {
            ChildFileWorker fileWorker = new ChildFileWorker(1024, ".txt");
            fileWorker.Read();
            fileWorker.Write();
            fileWorker.Edit();
            fileWorker.Delete();

            Console.ReadLine();
        }
    }
}

