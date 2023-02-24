using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwAdventureGame
{
    internal interface Iedible
    {
        public void Bite();

        public bool IsConsumed();

        public bool IsConsumed(int Bites);
    }
}
