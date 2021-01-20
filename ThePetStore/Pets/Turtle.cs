using System;
using System.Collections.Generic;
using System.Text;

namespace ThePetStore.Pets
{
    class Turtle
    {
        //Properties
        public string Name { get; set; }
        public string Size { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }

        //Fields - internal private things
        private bool _isHungry = true;

        //Constructor
        public Turtle(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine($"This turtle's name is {Name} and its age is {Age}");
        }

        //Method
        public void Eat(string foodType)
        {
            if (_isHungry)
            {
                Console.WriteLine($"The turtle stretches their neck out and munches on the {foodType}");
                _isHungry = false;
            } else
            {
                Console.WriteLine("The turtle shakes its head and says 'No thank you!'");
            }
            
        }

        public void ShowTime(string occasion)
        {
            if (occasion != null)
            {
                Console.WriteLine($"It is a {occasion}!");
            } else
            {
                Console.WriteLine($"No occasion...");
            }
            DressUp("Tie");
        }

        //Method Overloading
        public void Eat()
        {
            Eat("Pellets");
        }

        private void DressUp(string clothing)
        {
            Console.WriteLine($"The turtle is wearing a {clothing}");
        }
    }
}
