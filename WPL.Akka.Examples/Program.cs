using System;
using Akka.Event;

namespace WPL.Akka.Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            IotApp.Init();

            Console.ReadKey();
        }
    }
}
