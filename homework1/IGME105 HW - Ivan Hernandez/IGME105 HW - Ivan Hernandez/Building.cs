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
    internal class Building
    {
        public static bool RoomExploration(Setup setup)
        {

            
            int PlayerChoiceNumber;
            Random rand = new Random();
            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You can check the...\n1)Living Room \n2)Kitchen \n3){0}'s Room \n4)Storage Room \n5)Library \n6) Quit Game", setup.PlayerName);
                PlayerChoiceNumber = CV.CVNumber("Please enter a positive integer.");
                if (PlayerChoiceNumber >= 7)
                {
                    Console.WriteLine("Please enter a number from 1 to 6.");
                }
            }
            while (PlayerChoiceNumber <= 0 || PlayerChoiceNumber >= 7);

            bool Obj = false;

            switch (PlayerChoiceNumber)
            {
                // Room 1 (flavor)
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You enter the living room...Or what is supposed to be the living room. \nYou see a man and his dog sitting next to the fireplace. You think about talking to them, but your body freezes before you can leave the doorframe. \nYou decide to leave the room and return to the hallway.");
                    Obj = false;
                    break;
                // Room 2 (flavor)
                case 2:
                    Thread.Sleep(1000);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You enter the kitchen. The nice smell of a freshly baked pie hits your nostrils as you walk in. \nThere's a woman preparing some {0} on the kitchen countertop.\nYou also see some {1}, {2}, and {3}. \nThe urge to try some reveberates through your body, but you decide to eat the cookies when they're finished. \nYou return to the hallway.", setup.Playerinputstring[rand.Next(0,setup.Playerinputstring.Count+1)], setup.Playerinputstring[rand.Next(0, setup.Playerinputstring.Count + 1)], setup.Playerinputstring[rand.Next(0, setup.Playerinputstring.Count + 1)], setup.Playerinputstring[rand.Next(0, setup.Playerinputstring.Count + 1)]);
                    Obj = false;
                    break;
                // Room 3 (one item + flavor)
                case 3:
                    Console.WriteLine("You enter what you think is your room. A wave of nostalgia hits you as you see your favorite {0} sword on the bed...Wait, you had a sword?", setup.colors);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    string SwordGet;
                    do
                    {
                        Console.WriteLine("Do you pick up the sword? Y/N");
                        SwordGet = CV.CVYORN("Please enter Y or N.");

                        if (SwordGet.Substring(0) == "N")
                        {
                            Console.WriteLine("You decide to evaluate all of your options before getting the sword.");
                            Obj = false;
                        }

                        if (SwordGet.Substring(0) == "Y")
                        {
                            Console.WriteLine("You decide to pick up the sword. An invigorating wave flows through you!");
                            Obj = true;
                        }

                    }
                    while (String.IsNullOrEmpty(SwordGet) || SwordGet.Substring(0) != "Y" & SwordGet.Substring(0) != "N");
                    Console.WriteLine("You decide to leave the area and go back to the hallway.");
                    break;
                // Room 4 (flavor)
                case 4:
                    Console.WriteLine("You enter the storage room. You see mountains of boxes stacked one after another. That shouldn't even be possible... \nYou feel an omnious presence pierce through you from one of the boxes.. \nYou decide to return to the hallway.");
                    Obj = false;
                    break;
                // Room 5 (flavor)
                case 5:
                    Console.WriteLine("You enter the library. You see two young children reading incredbily large books. \nThey're so absorbed, they don't notice your presence. \nYou decide to return to the hallway.");
                    Obj = false;
                    break;
                // Quit
                case 6:
                    Setup.EndTheGame(setup, "You got tired of exploring and went back to your room. \nYou took a nap that you never woke up from...");
                    break;
            }
            return Obj;
        }

        public static void DungeonDoorChallenge(Setup setup)
        {

            
            int PlayerChoiceNumber;
            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("GAMEPLAY! What should you do?");
                Console.WriteLine("1) Slash at the man \n2) Run away \n3) Pet the dog");
                PlayerChoiceNumber = CV.CVNumber("Please enter a positive integer.");
                if (PlayerChoiceNumber >= 4)
                {
                    Console.WriteLine("Please enter a number from 1 to 3.");
                }
            }
            while (PlayerChoiceNumber <= 0 || PlayerChoiceNumber >= 4);

            switch (PlayerChoiceNumber)
            {
                // Option 1
                case 1:
                    Setup.EndTheGame(setup, "You tried to slash at the man, but his body refused to make contact with the sword. It's like he's not even there... \nIn your confusion, the dog bites your hand as the feeling of static begins to flow through you... \nYou black out... \n GAME OVER");
                    break;
                // Option 2
                case 2:
                    Setup.EndTheGame(setup, "You tried running away, but the man and dog seemed to be around every corner. \nThe man finally grabs you as the feeling of static begins to flow through your body. \nYou black out... \nGAME OVER");
                    break;
                // Option 3
                case 3:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You pet the dog. \nIt distracts the man-dog tag team for just long enough for you to stab the ground, creating a hole in the floor! \nYou jump down without thinking, trying to avoid your pursurers...");
                    break;
            }

        }

    }
}
