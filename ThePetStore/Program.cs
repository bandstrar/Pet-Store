using System;
using ThePetStore.Pets;

namespace ThePetStore
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Turtle turtle1 = new Turtle("Yertle", 72);
            turtle1.Eat();
            turtle1.Eat("lettuce");
            turtle1.ShowTime("Bar-Mitzvah");
            Console.WriteLine($"{turtle1.Name} is {turtle1.Age} years old.");

            Scorpion scorpion = new Scorpion("Steven");
            scorpion.Attack();
        }
    }
}
