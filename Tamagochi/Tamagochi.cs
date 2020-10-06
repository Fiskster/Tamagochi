using System;
using System.Collections.Generic;

namespace Tamagochi
{
    public class Tamagochi
    {
        private int hunger = 100;
        private int boredom;
        
        private List<string> words = new List<string>() {"Hi!", "Greetings.", "Bruh!", "Cringe", "Based"};

        private Random Generator = new Random();

        public string name = ""; 

        private bool isAlive = true;

    
        public void Feed()
        {
          hunger = hunger - 10;
        }
        public void Hi()
        {
            string greeting = words[Generator.Next(4)];
            Console.WriteLine(greeting);
            ReduceBoredom();
        }
        private void ReduceBoredom()
        {
            boredom = boredom - 10; 
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
    }
}
