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
    internal abstract class Cat
    {
        private int attackSkill = 0;

        public Cat(int attackSkill)
        {
            this.attackSkill = attackSkill;
        }

        public abstract bool Attack();
        protected virtual bool IsAttackSuccessful()
        {
            bool attackhit = false;
            int Check = Setup.DiceRoll(1, 7);
            if (attackSkill > Check)
            {
                attackhit = true;
            }
            else
            {
                attackhit = false;
            }
            return attackhit;
        }

    }
}
