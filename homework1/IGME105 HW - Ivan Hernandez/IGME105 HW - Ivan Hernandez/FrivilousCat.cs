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
    internal class FrivilousCat : Cat
    {
        private string name = "Frivilous Cat";
        public string Name
            { get { return name; } }

        const int SKILLLEVEL = 4;
        public FrivilousCat(): base(SKILLLEVEL)
        {
        }

        public override bool Attack()
        {
            Console.WriteLine("The frivilous cat slashes at you with their gaudy claws!");
            bool Live = base.IsAttackSuccessful();
            return Live;
        }

    }
}
