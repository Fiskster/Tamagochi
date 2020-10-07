using System;
using System.Collections.Generic;
using System.Threading;
namespace Tamagochi
{
    public class Tamagochi
    {
        private int hunger = 0;
        private int boredom = 0;

        private List<string> words = new List<string>() { "Hi!", "Greetings.", "Bruh!", "Cringe", "Based" };

        private Random Generator = new Random();

        public string name = "";

        private bool isAlive = true;

        public void Tick()
        {
           Thread thread = new Thread(Tick);
           thread.Start(2);
           Thread.Sleep(15000);
           
            boredom = boredom + 10;
            hunger = hunger + 10;
        }

        public void Feed()
        {
            hunger = hunger - Generator.Next(2,20);
        }
        public void Hi()
        {
            string greeting = words[Generator.Next(0,5)];
            Console.WriteLine(greeting);
            ReduceBoredom();
        }
        private void ReduceBoredom()
        {
            boredom = boredom - Generator.Next(2,20);
        }
        public void Teach(string word)
        {
            words.Add(word);
            ReduceBoredom();
        }
        public void PrintStats()
        {
            System.Console.WriteLine(hunger);
            System.Console.WriteLine(boredom);
            if (isAlive == true)
            {
                System.Console.WriteLine("Your Tamagochi is alive!");
            }
            else
            {
                System.Console.WriteLine("Your Tamagochi is dead :(");
            }
        }
        public bool GetAlive()
        {
            return isAlive;
        }
    
    }
}
