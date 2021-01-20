using System;
using System.Collections.Generic;
using System.Text;

namespace ThePetStore.Pets
{
    //A class is implicity internal
    class Scorpion
    {
        //Inside class things are implicitly private
        public int StingerWidth { get; set; }
        public string Origin { get; set; }
        public string Name { get; set; }
        public bool DoesGlow { get; set; }

        //Constructor
        public Scorpion(string name)
        {
            Name = name;
            DoesGlow = true;
        }

        //Methods
        public void Attack()
        {
            if (DoesGlow)
            {
                Console.WriteLine("The scorpion attacks you! Get to the hospital!");
            }
            else
            {
                Console.WriteLine("The scorpion kisses you. Your bond deepens.");
            }
        }
    }
}
