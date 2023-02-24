/* Name: HW Adventure Game (Name TBD)
 * Creator: Ivan Hernandez
 * Purpose: Make a text-based adventure game
 * Date: 9/9/222
 * GIT REPO: https://kgcoe-git.rit.edu/iah7731/homework1
 * Modification:
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwAdventureGame
{
    internal class LazyCat : Cat, Iedible
    {
        public void Bite()
        {
            Console.WriteLine("You decided to eat the lazy cat (you actual psychopath).");
            bool eaten = this.IsConsumed();
            if (eaten == true)
            {
                Console.WriteLine("You just ate a cat alive. I have no words.");
            }
            else
            {
                Console.WriteLine("The cat got away (thank god). This is a bug though.");
            }
            
        }

        public bool IsConsumed()
        {
            if (this.isConsumed == false)
            {
                this.isConsumed = true;
            }
            return this.isConsumed;
        }

        public bool IsConsumed(int Bites)
        {
            return this.isConsumed;
        }
        private string name = "Lazy Cat";
        public string Name
        { get { return name; } }

        private bool isConsumed = false;

        public bool isconsumed
        {
            get { return isConsumed; }
            set { isConsumed = value; }
        }

        const int SKILLLEVEL = 2;
        public LazyCat() : base(SKILLLEVEL)
        {
        }

        public override bool Attack()
        {
            Console.WriteLine("The lazy cat slashes at you while mumbling about Mondays!");
            bool Live = base.IsAttackSuccessful();
            return Live;
        }


    }
}
