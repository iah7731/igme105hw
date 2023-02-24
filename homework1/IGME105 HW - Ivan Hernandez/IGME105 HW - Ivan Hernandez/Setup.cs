/* Name: HW Adventure Game (Name TBD)
 * Creator: Ivan Hernandez
 * Purpose: Make a text-based adventure game
 * Date: 9/9/222
 * GIT REPO: https://kgcoe-git.rit.edu/iah7731/homework1
 * Modification:
*/

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwAdventureGame
{
    internal class Setup
    {
        int savepoint = 0;

        public int Savepoint
        { get { return savepoint; } set { savepoint = value; } }

        string[] COLORS = new string[] { "blue", "green", "purple", "pink", "red", "orange", "yellow", "indigo" };

        public string colors
        {
            get
            {
                Random myrand = new Random();
                return COLORS[myrand.Next(COLORS.Length)];
            }
        }

        int[] PlayerInputNumbers = new int[10];

        //String to ask for animal type and int to say how many of that type there are

        Dictionary<string, int> Animals = new Dictionary<string, int>();

        public int[] Playerinputnumbers
        {
            get { return PlayerInputNumbers; }
        }

        List<string> PlayerInputString = new List<string>();

        public List<string> Playerinputstring
        {
            get { return PlayerInputString; }
        }

        bool GetPlayerRoomObj = false;

        public bool Getplayerroomobj
        {
            get { return GetPlayerRoomObj; }
            set { GetPlayerRoomObj = value; }
        }

        string playerName="";

        public string PlayerName
        {
            get { return playerName; }
        }

        public static void WelcomeToTheGame(Setup setup)
        {

            // Welcome to the game

            Console.WriteLine("Welcome to VisoQuest!");
            Console.WriteLine("Would you like to load a previous save? (Y/N)");
            string checksave = CV.CVYORN("Please enter Y or N.");
            switch(checksave)
            {
                case ("Y"):

                    // Check and recreate the setup file

                    setup.savepoint = DM.DReadSaveData();
                    string ts = DM.DReadTS();
                    Setup.RecreateSetup(ts);

                    // Return to the proper game state

                    Setup.RestorePlayState(setup);

                    break;

                case ("N"):
                    break;
            }

            // Player Name

            Console.WriteLine("What's your name?");
            bool validName;
            do
            {
                setup.playerName = Console.ReadLine().Trim();
                validName = CV.CVString(setup.playerName, "Please enter a valid integer greater than 0.");

            }
            while (validName == false);
            Setup.Difficulty(setup);
            Setup.GetPlayerInputNums(setup);
            Setup.AddPlayerInputList(setup);


        }

        public static void Difficulty(Setup setup)
        {
            Console.WriteLine("What difficulty do you want? \n1)Easy \n2)Normal \n3)Hard");
            int difficulty = CV.CVNumber("Please enter a valid number.");
            Random rand = new Random();
            for (int i = 0; i < difficulty; i++)
            {
                setup.Animals.Add("Faceless" + i, 1);
            }


        }

        public static string ConfirmGame(string playerName)
        {
            // Explain the game

            Console.WriteLine("Hello, {0}! Let me introduce the game before you start playing.\n This is a text adventure game. Just enter something when you're prompted.\n All you need is your keyboard!", playerName);
            Console.WriteLine("Are you ready to play, {0}? (Y/N)", playerName);

            string Answer;
            Answer = CV.CVYORN("Please enter Y or N.");
            return Answer;
        }

        public static int DiceRoll(int Min, int Max)
        {
            // Roll dice
            int DieRoll;
            Random DiceRoll = new Random();
            DieRoll = DiceRoll.Next(Min, Max);
            return DieRoll;
        }

        public static int DiceRoll(int Min, int Max, int DiceNumber)
        {
            // Roll dice
            int DieRoll;
            Random DiceRoll = new Random();
            DieRoll = DiceRoll.Next(Min, Max);
            DieRoll = (DieRoll * DiceNumber) / DiceNumber;
            return DieRoll;
        }

        public static void GetPlayerInputNums(Setup setup)
        {
            Console.WriteLine("Please enter 10 numbers to customize your user experience. Press enter to continue.");
            Console.ReadLine();
            for (int i = 0; i < setup.PlayerInputNumbers.Length; i++)
            {
                int input = 0;
                Console.WriteLine("Please enter number {0} of 10...", i);
                do
                {
                    input = CV.CVNumber("Please enter a number.");
                    if (input <= 9)
                    {
                        Console.WriteLine("Please enter a number between 10 and 100.");
                    }
                    if (input >= 101)
                    {
                        Console.WriteLine("Please enter a number between 10 and 100.");
                    }

                } while (input <= 9 || input >= 101);

                setup.PlayerInputNumbers[i] = input;
            }

            Console.WriteLine("This is all of the numbers you've inputted.");
            foreach (int var in setup.PlayerInputNumbers)
            {
                Console.WriteLine(setup.PlayerInputNumbers[(int)var]);
            }

        }

        public static void AddPlayerInputList(Setup setup)
        {
            Console.WriteLine("Please enter at least 4 foods to customize your user experience. Press enter to continue.");
            Console.ReadLine();
            bool ExitLoop = false;
            string AddToList;
            bool validity;
            int LoopAmount = 0;
            do
            {
                Console.WriteLine("Add another food item?");
                string Input = CV.CVYORN("Please enter Y or N.");
                if (Input == "N")
                {
                    if (LoopAmount <= 3)
                    {
                        Console.WriteLine("You need to add at least 4 entries to continue.");
                        ExitLoop = false;
                    }
                    else
                    {
                        ExitLoop = true;
                    }
                }

                if (Input == "Y")
                {
                    do
                    {
                        Console.WriteLine("What would you like to add?");
                        AddToList = Console.ReadLine().Trim();
                        validity = CV.CVString(AddToList, "Please enter a valid string.");
                    }
                    while (validity == false);
                    setup.Playerinputstring.Add(AddToList);
                }

            } while (ExitLoop == false);
        }

        public override string ToString()
        {
            string ts = savepoint +"+++"+PlayerInputNumbers.ToString() + "+++" + PlayerInputString + "+++" + Animals.ToString() + "+++" + PlayerName;
            return ts;
        }

        public static void RecreateSetup(string ts)
        {
            // Split the values

            string[] splitvalues = ts.Split("+++");

            // Copy over everything

            Setup setup = new Setup();

            // Save point

            setup.savepoint = CV.CVNumber(splitvalues[0],"Integer could not be parsed.");

            // Player Input Numbers

            string[] newplayernums = splitvalues[1].Split(",");
            int[] ints = new int[newplayernums.Length];
            for (int i = 0; i < newplayernums.Length; i++)
            {
                ints[i] = CV.CVNumber(newplayernums[i],"Integer could not be parsed.");
            }
            setup.PlayerInputNumbers = ints;

            // Player input string

            string pis = splitvalues[2].ToString();
            setup.PlayerInputString=pis.Split(",").ToList();

            // Player name

            setup.playerName = splitvalues[4];


        }
        public static void RestorePlayState(Setup setup)
        {
            // Return to the proper game state

            switch (setup.savepoint)
            {
                case 0:
                    Gameplay.GameplayState0(setup);
                    break;
                case 1:
                    Gameplay.GameplayState1(setup);
                    break;
                case 2:
                    Gameplay.GameplayState2(setup);
                    break;
                case 3:
                    Gameplay.GameplayState3(setup);
                    break;
                case 4:
                    Gameplay.GameplayState4(setup);
                    break;
                case 5:
                    Gameplay.GameplayState5(setup);
                    break;
            }

        }

        public static void EndTheGame(Setup setup, string EndGameQuote)
        {
            // End the game with a "funny" quote

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(EndGameQuote);

            Console.WriteLine("Would you like to load a previous state? (Y/N)");
            string confirm = CV.CVYORN("Please enter Y or N.");

            switch (confirm)
            {
                case ("Y"):
                    Setup.RestorePlayState(setup);
                    break;
                case ("N"):
                    Console.WriteLine("Press enter to exit the game.");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;

            }

            
        }

    } 
}
