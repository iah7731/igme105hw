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
    internal class Dungeon
    {
        // Create the four rooms of the dungeon
        // Room 1 Challenge
        public static void Dungeon1Challenge(Setup setup, string playerName)
        {

            
            int PlayerChoiceNumber;
            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("GAMEPLAY! What should you do?");
                Console.WriteLine("1) Listen to call of the void \n2) Push forward \n3) Shoot the raygun! \n4) End the game");
                PlayerChoiceNumber = CV.CVNumber("Please enter a positive integer.");
                if (PlayerChoiceNumber >= 5)
                {
                    Console.WriteLine("Please enter a number from 1 to 4.");
                }
            }
            while (PlayerChoiceNumber <= 0 || PlayerChoiceNumber >= 4);

            switch (PlayerChoiceNumber)
            {
                // Option 1
                case 1:
                    Setup.EndTheGame(setup, "You decide to heed the call of the void. You walk up to one of the cracks in the floor and put your hand on it. \nYou begin to be absorbed into the crack as you feel a wave of static wash over your body...\nYou stop thinking and let yourself become absorbed in the nothingness... \n GAME OVER");
                    break;
                // Option 2
                case 2:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You push forward into the distorted reality.\nAfter walking for what feels like an eternity, you eventually stumble into another person cooking. \nYou watch at a distance, not sure if they're human or not...");
                    break;
                // Option 3
                case 3:
                    Setup.EndTheGame(setup, "You shot the raygun at one of the cracks in the floor. \nIt opens up a portal to jump through! \nYou hop into the portal without thinking, desperate to escape...wherever that was. \nAs you travel through the portal, you hear a loud siren blare\"" + playerName + "-627 HAS BREACHED CONTAINMENT!\"...You have a feeling this is a entirely different genre now. \nTRAVELLER ENDING");
                    break;
                case 4:
                    Setup.EndTheGame(setup, "You didn't feel like playing anymore, so you ended the game.");
                    break;
            }

        }

        // Room 2 + door puzzle

        public static void Dungeon2Challenge(Setup setup, string playerName)
        {
            int PlayerChoiceNumber;
            int CatType = Setup.DiceRoll(1, 3);
            string CatName;
            Cat newcat;

            switch (CatType)
            {
                case 1:
                    newcat = new LazyCat();
                    CatName = "Lazy Cat";
                    break;
                case 2:
                    newcat = new FrivilousCat();
                    CatName = "Frivilous Cat";
                    break;
                default:
                    goto case 1;
            }

            Console.WriteLine("Alongside the woman, you see a {0}. You wonder how to approach it...", CatName);

            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("GAMEPLAY! What should you do?");
                Console.WriteLine("1) Eat the cookies \n2) Politely decline \n3) Pretend to eat the cookie \n4) Approach the cat\n5) End the game");
                PlayerChoiceNumber = CV.CVNumber("Please enter a positive integer.");
                if (PlayerChoiceNumber >= 6)
                {
                    Console.WriteLine("Please enter a number from 1 to 5.");
                }
                
            }
            while (PlayerChoiceNumber <= 0 || PlayerChoiceNumber >= 6);

            switch (PlayerChoiceNumber)
            {
                // Option 1
                case 1:
                    Setup.EndTheGame(setup, "You eat one of the cookies. You feel an odd static sensation from your mouth spread throughout your body...\nWhat were in those cookies? \n GAME OVER");
                    break;
                // Option 2
                case 2:
                    Setup.EndTheGame(setup, "You try to decline, but the woman insists with the calm assertions only a mother could make. \nAfter a lot of convincing, you decide to eat a cookie to make the faceless woman happy. \nYou feel an odd static sensation from your mouth spread throughout your body...\nWhat were in those cookies? \n GAME OVER");
                    break;
                // Option 3
                case 3:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You pretend to eat the cookie to satisfy the faceless woman. She seems satisfied and turns her back on you. You use the opprotunity to sprint as fast as you can!");
                    break;
                case 4:
                    Console.WriteLine("You approached the cat...");
                    CatAttack(setup, newcat, CatName);

                    break;
                case 5:
                    Setup.EndTheGame(setup, "You didn't feel like playing anymore, so you ended the game.");
                    break;
            }
        }

        // Room 3 + door puzzle

        public static void Dungeon3Challenge(Setup setup, string playerName)
        {

            
            int PlayerChoiceNumber;
            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("GAMEPLAY! What should you do?");
                Console.WriteLine("1) Touch the orb \n2) Ponder the orb \n3) Smash the orb \n4) End the game");
                PlayerChoiceNumber = CV.CVNumber("Please enter a positive integer.");
                if (PlayerChoiceNumber >= 5)
                {
                    Console.WriteLine("Please enter a number from 1 to 4.");
                }
            }
            while (PlayerChoiceNumber <= 0 || PlayerChoiceNumber >= 4);

            switch (PlayerChoiceNumber)
            {
                // Option 1
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You touch the orb and it starts shaking violently. It seems like all of the cracks in time and other irregularities converge inside of the orb... \nWhat did you do?");
                    break;
                // Option 2
                case 2:
                    Setup.EndTheGame(setup, "You ponder the orb. The pale glow of the orb fills your body with a calmness you've never felt before. \nYou stare at the orb for minutes into hours into days into years...\nPONDER ENDING");
                    break;
                // Option 3
                case 3:
                    Setup.EndTheGame(setup, "You smash the orb onto the floor. Surprisinglly, nothing happens. Now all you have is a smashed orb. \nHow are you gonna get out of this? \nGAME OVER");
                    break;
                case 4:
                    Setup.EndTheGame(setup, "You didn't feel like playing anymore, so you ended the game.");
                    break;
            }


        }

        // Room 4 + door puzzle

        public static void Dungeon4Challenge(Setup setup, string playerName)
        {

            
            int PlayerChoiceNumber;
            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("GAMEPLAY! What should you do?");
                Console.WriteLine("1)Shoot the monster \n2)Slash at the monster \n3)Refuse to fight \n4) End the game");
                PlayerChoiceNumber = CV.CVNumber("Please enter a positive integer.");
                if (PlayerChoiceNumber >= 5)
                {
                    Console.WriteLine("Please enter a number from 1 to 4.");
                }
            }
            while (PlayerChoiceNumber <= 0 || PlayerChoiceNumber >= 4);

            switch (PlayerChoiceNumber)
            {
                // Option 1
                case 1:
                    Setup.EndTheGame(setup, "You end the monster with one straight shot to the cranium as it melts into a puddle of static. You can't help but feel like you made a mistake. \nWhy did you wake up here? Why can't you remember anything? \nYou leave the house with more questions than answers. NEUTRAL ENDING");
                    break;
                // Option 2
                case 2:
                    Setup.EndTheGame(setup, "You channel all of your energy into a single strike on the monster! It reels back in pain, but not for long... \nThe monster starts regenerating the damage. You slash and slash, but to no avail. \nThe monster absorbs your sword as you slash, bringing you closer. You try to fight, but you eventually end up getting absorbed into the monster... \nGAME OVER");
                    break;
                // Option 3
                case 3:
                    Console.WriteLine("3) You refuse to fight the monster. You realized something as you looked at the monster closer...It was in pain. \nYou walk up to the monster slowly...");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("It's a gamble if it will work or not.");
                    Console.WriteLine("Press enter to determine your fate.");
                    Console.ReadLine();
                    int Fate = Setup.DiceRoll(1, 7);
                    if (Fate == 1)
                    {
                        Setup.EndTheGame(setup, "You walk up to the monster and hugged it. \nIt responds by absorbing you into itself. \nI really don't know what you were expecting. You really thought this was Undertale, huh? \nGAME OVER");
                    }
                    else
                    {
                        Setup.EndTheGame(setup, "You walk up to the monster and hugged it. It responds by embracing you back. You thought it would hurt, but it felt nice as the monster seemed to dissolve into you. \nSuddenly, everything comes back to you...That raygun. \nYou take the raygun out of your pocket and stare at it before smashing it against the floor, shattering it. \nIt was the cause of all the distortions. Everything around you returns to normal and fades to white before you wake up in your bed. \nYou hear someone call out to you...\"Get over here! Dinner's ready!\" \nYou crawl out of bed and get ready to tackle the rest of the day. GOOD ENDING");
                    }
                    break;
                case 4:
                    Setup.EndTheGame(setup, "You didn't feel like playing anymore, so you ended the game.");
                    break;
            }

        }

        public static void CatAttack(Setup setup,Cat newcat,string CatName)
        {
            Console.WriteLine("You approach the {0}...", CatName);
            
                bool die = newcat.Attack();
                if (die == false)
                {
                    Console.WriteLine("You managed to dodge the attack!.");
                    if(CatName == "Lazy Cat")
                    {
                        Console.WriteLine("You decided to take revenge on the cat for trying to kill you...");
                        LazyCat lazycat = new LazyCat();
                        lazycat.Bite();
                    }
                
                }
                else if (die == true)
                {
                    Setup.EndTheGame(setup, "You got hit by the cat's claw and died.");
                }
        }
           
    }
}
        

    

