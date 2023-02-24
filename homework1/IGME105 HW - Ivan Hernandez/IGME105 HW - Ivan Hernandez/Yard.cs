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
    internal class Yard
    {
        public static void StepsChallenge(int PathSteps)
        {
            // Ask the player how many steps they want to move

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("GAMEPLAY! How many steps do you want to walk?");
            int StepsTakenNumber = -1;
            int StepsTakenOnPath = 0;

            // Check for valid user input
            do
            {
                StepsTakenNumber = CV.CVNumber("Please enter a positive integer.");

                 StepsTakenOnPath = PathSteps - StepsTakenNumber;

                if (StepsTakenNumber > PathSteps)
                {
                    int OvershotIt = StepsTakenNumber - PathSteps;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You were going to walk {0} steps, but you reached the house with {1} steps left.", StepsTakenNumber, OvershotIt);
                }
                if (StepsTakenNumber < PathSteps)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You only walked {0} steps. You didn't reach the door.", StepsTakenNumber);
                }

            }
            while (StepsTakenOnPath > 0);
            
        }
        public static bool DoorChallenge(string playerName)
        {
            // Setup

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\"Hello! This is {0}'s house. If you need to enter, you know where the key is.\"", playerName);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Except...If this is supposed to be your house, why don't you remember how to get in?");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("GAMEPLAY! Press the spacebar to roll two six sided dice. If you get above four, you can keep playing! \nIf not, then...you'll find out.");
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();

            // Roll two dice

            int DiceRoll1 = Setup.DiceRoll(1, 7);
            int DiceRoll2 = Setup.DiceRoll(1, 7);

            // Add them and return the value

            int FinalNumber = DiceRoll1 + DiceRoll2;
            bool Survival = false;

            if (FinalNumber >= 4)
            {
                Survival = true;
            }

            if (FinalNumber < 4)
            {
                Survival=false;
            }

            return Survival;

        }

        public static void AnimalChallenge(Setup setup)
        {
            bool Obj = false;
            int PlayerChoiceNumber;
            Random rand = new Random();
            int[] AnimalAttributes = new int[] { rand.Next(0, 10), rand.Next(0, 10), rand.Next(0, 10), rand.Next(0, 10), rand.Next(0, 10), rand.Next(0, 10), };
            Faceless Faceless1 = new Faceless();
            Faceless Faceless2 = new Faceless();
            Faceless1.Legnum = setup.Playerinputnumbers[rand.Next(0,10)];
            Faceless2.Legnum = setup.Playerinputnumbers[rand.Next(0, 10)];
            do
            {
                do
                {
                    Console.WriteLine("The creatures have an abnormal amount of legs...\n The first one has {0} and the second one has {1}. \nWhere have you seen those numbers before..?", Faceless1.Legnum, Faceless2.Legnum);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("GAMEPLAY! What should you do?");
                    Console.WriteLine("1) Try and bum rush your way in \n2) Pet the first creature and greet the second  \n3) Pet the second creature and greet the first \n4) Inspect the creatures \n5) Eat a creature (what?) \n6) End the game ");
                    PlayerChoiceNumber = CV.CVNumber("Please enter a positive integer.");
                    if (PlayerChoiceNumber >= 7)
                    {
                        Console.WriteLine("Please enter a number from 1 to 6.");
                    }
                }
                while (PlayerChoiceNumber <= 0 || PlayerChoiceNumber >= 7);

                switch (PlayerChoiceNumber)
                {
                    // Option 1
                    case 1:
                        Setup.EndTheGame("You decide to force your way into the house. \nBefore you can even put the key in the hole, you begin to feel a staticy sensation on your leg. You look down and see the first creature biting you. \nDang it. \nYou succumb to the static. \nGAME OVER");
                        Obj = true;
                        break;
                    // Option 2
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You pet the first creature and greet the second. \nSeeming satisfied, the two seem to fade away. Primed for the task at hand, you enter your\"house\".");
                        Obj = true;
                        break;
                    // Option 3
                    case 3:
                        Setup.EndTheGame("You pet the second creature and greet the first. \nSeeming dissatisfied, the first creature bites you. \nDang it. \nYou succumb to the static. \nGAME OVER");
                        Obj = true;
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You take a closer look at the creatures. The first creature has a nametag that says {0}, a creepiness factor of {1} and a hospitality factor of {2}. The other creature has a nametag that says {3}, a creepiness factor of {4} and a hospitality factor of {5}.",Faceless1.Name[AnimalAttributes[0]], Faceless1.creepiness[AnimalAttributes[1]], Faceless1.hospitality[AnimalAttributes[2]], Faceless2.Name[AnimalAttributes[3]], Faceless2.creepiness[AnimalAttributes[4]], Faceless2.hospitality[AnimalAttributes[5]]);
                        Obj = false;
                        break;
                    case 5:
                        Faceless1.Bite();
                        break;
                    case 6:
                        Setup.EndTheGame("You didn't feel like playing anymore, so you ended the game.");
                        Obj = false;
                        break;
                }
            }
            while (Obj == false);

            setup.Savepoint++;
        }

    }
}
