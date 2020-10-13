using System;
using System.Threading;

namespace Tamagochi
{
    class Program
    {
        static void Main(string[] args)
        {
             Tamagochi gochi = new Tamagochi();
        //     Thread thread = new Thread(gochi.Tick);
        //    thread.Start();
        //    Console.WriteLine("cum");
        //    Thread.Sleep(100);
         
           
           

            System.Console.WriteLine("Hello! I am your Tamagochi.");
            bool correctInput = false;
            while (correctInput == false)
            {
                System.Console.WriteLine("What is my name?");
                string name = Console.ReadLine();
                gochi.name = name;
                System.Console.WriteLine("My name is " + name + " , are you sure? Press Y if you are sure.");
                ConsoleKeyInfo UI = Console.ReadKey();
                if (UI.Key == ConsoleKey.Y)
                {
                 correctInput = true; 
                 
                }
               
            }
            Console.Clear();
            gochi.Hi();

        }
    }
}
