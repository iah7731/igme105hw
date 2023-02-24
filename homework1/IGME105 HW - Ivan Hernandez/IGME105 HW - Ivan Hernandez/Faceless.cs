/* Name: HW Adventure Game (Name TBD)
 * Creator: Ivan Hernandez
 * Purpose: Make a text-based adventure game
 * Date: 9/9/222
 * GIT REPO: https://kgcoe-git.rit.edu/iah7731/homework1
 * Modification:
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwAdventureGame
{
    internal class Faceless : Iedible
    {
        // Have creepiness and hospitality
        // one will prefer being pet and the other will prefer a greeting
        // have something to inspect their stats
        // you have to choose which one to pet and which to greet and if you choose wrong you die
        int[] Creepiness = new int[] { 11, 2, 20, 9, 15, 6, 8, 3, 14, 18 };
        public int[] creepiness
        {
            get { return Creepiness; }
        }
        int[] Hospitality = new int[] {23,19,28,22,14,24,20,28,27,30};

        public int[] hospitality
        {
            get { return Hospitality; }
        }

        string[] name = new string[] { "Faceless","Nameless","Meaningless","Handless","Eyeless","Brainless","Copulus","Seether","Maldro","Morbius"};

        int LegNum = 0;

        public int Legnum
        {
            get { return LegNum; }
            set {
                if (value <= 9)
                {
                    Console.WriteLine("Please enter a number between 10 and 100.");
                    LegNum = 10;
                }
                else if (value >= 101)
                {
                    Console.WriteLine("Please enter a number between 10 and 100.");
                    LegNum = 100;

                }
                else
                {
                    LegNum = value;
                }


            }
        }
        public string[] Name
        {
            get { return name; }
        }

        public void Bite()
        {
            Console.WriteLine("You decided to eat the faceless creature (you actual psychopath). \nPress enter to continue.");
            Console.ReadLine();

            int i = 0;
            bool eaten = false;

            for (i = 0; i < 6; i++)

            eaten = this.IsConsumed(i);
            if (eaten == false)
            {
                Console.WriteLine("You took bite {0} of 6 to eat the faceless creature...\nPress enter to continue.", i);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You finished eating the creature (why did you do that?).\nPress enter to continue.");
                Console.ReadLine();
            }

        }

        public bool IsConsumed(int Bites)
        {
            if (Bites != 6)
            {
                this.isConsumed = false;
            }
            else
            {
                this.isConsumed = true;
            }
            return this.isConsumed;
        }

        public bool IsConsumed()
        {
            return this.isConsumed;
        }

        private bool isConsumed = false;
        public bool isconsumed
        {
            get { return isConsumed; }
            set { isConsumed = value; }
        }

    }
}
