using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwAdventureGame
{
    internal class Gameplay
    {
        public static void GameplayState0(Setup setup)
        {
            // Initial story setup (highlight the yard)

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You wake up on the front lawn of a weird house...\nYou look around and see a path towards the house.\nYou decide to walk on it since you don't have any better ideas.");

            // Setup the path that leads to the house

            const int PATHSTEPS = 20;

            Yard.StepsChallenge(PATHSTEPS);

            // Door challenge

            bool DoorCheck = Yard.DoorChallenge(setup.PlayerName);
            Console.WriteLine("You rolled {0}.", DoorCheck);

            if (DoorCheck == true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You checked underneath the doormat and found the key!");
            }

            if (DoorCheck == false)
            {
                Setup.EndTheGame(setup, "You checked underneath a flower pot for the key. \nUnfortunately, it was rigged with explosives. You die in a blaze of glory, unsure of your own identity.");
            }

            // Animal challenge

            Console.WriteLine("You were about to enter the house, but something begins to materialize in front of you!");
            Console.WriteLine("You can't even describe what's in front of you...You'll have to assess the situation carefully to continue.");
            Yard.AnimalChallenge(setup);

            // Enter the house

            Console.WriteLine("Once you're inside the house, you see a glowing {0} raygun on the floor. You decide to pick it up for now.", setup.colors);
            Console.WriteLine("You look around the hallway and see five...rooms(?) to enter. You decide to enter...");

            // Create the 5 rooms of the house 

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("GAMEPLAY! Look around the house and see what the deal is. \nEnter a number to select a room to check. \nPress enter to continue.");
            Console.ReadLine();
            do
            {
                setup.Getplayerroomobj = Building.RoomExploration(setup);
            }
            while (setup.Getplayerroomobj == false);

            // Place the dungeon entrance in the living room

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You get the urge to return to the living room. As you enter, the room begins warping and turning to static. \nThe man and dog turn to face you as they sense your presence. Except for the fact that they have...no face? \nThe pair begin walking towards you slowly...");

            // Dungeon door challenge

            Building.DungeonDoorChallenge(setup);

            // Introduce the first puzzle

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You land in the basement of the house. Reality itself is warping. \nThe raygun from earlier begins to glow in your pocket. \nYou feel the cracks in time calling you.");
            Dungeon.Dungeon1Challenge(setup, setup.PlayerName);

            // Introduce the second puzzle

            Console.WriteLine("The woman notices your presence. \"{0}! Where have you been? I made your favorite cookies!");
            Dungeon.Dungeon2Challenge(setup, setup.PlayerName);

            // Introduce the third puzzle

            Console.WriteLine("After running for a while, you come across an orb on a pedestal. It's warm glow reaches out to you...");
            Dungeon.Dungeon3Challenge(setup, setup.PlayerName);

            // Introduce the last puzzle

            Console.WriteLine("The orb grows in size and turns into an amalgamation of every faceless person you've seen so far. You can't even call it an orb anymore; it's a monster now. \nYou have a feeling this is the final challenge you have to face!");
            Dungeon.Dungeon4Challenge(setup, setup.PlayerName);
        }

        public static void GameplayState1(Setup setup)
        {

            // Enter the house

            Console.WriteLine("Once you're inside the house, you see a glowing {0} raygun on the floor. You decide to pick it up for now.", setup.colors);
            Console.WriteLine("You look around the hallway and see five...rooms(?) to enter. You decide to enter...");

            // Create the 5 rooms of the house 

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("GAMEPLAY! Look around the house and see what the deal is. \nEnter a number to select a room to check. \nPress enter to continue.");
            Console.ReadLine();
            do
            {
                setup.Getplayerroomobj = Building.RoomExploration(setup);
            }
            while (setup.Getplayerroomobj == false);

            // Place the dungeon entrance in the living room

            setup.Savepoint++;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You get the urge to return to the living room. As you enter, the room begins warping and turning to static. \nThe man and dog turn to face you as they sense your presence. Except for the fact that they have...no face? \nThe pair begin walking towards you slowly...");

            // Dungeon door challenge

            Building.DungeonDoorChallenge(setup);

            // Introduce the first puzzle

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You land in the basement of the house. Reality itself is warping. \nThe raygun from earlier begins to glow in your pocket. \nYou feel the cracks in time calling you.");
            Dungeon.Dungeon1Challenge(setup, setup.PlayerName);

            // Introduce the second puzzle

            Console.WriteLine("The woman notices your presence. \"{0}! Where have you been? I made your favorite cookies!");
            Dungeon.Dungeon2Challenge(setup, setup.PlayerName);

            // Introduce the third puzzle

            Console.WriteLine("After running for a while, you come across an orb on a pedestal. It's warm glow reaches out to you...");
            Dungeon.Dungeon3Challenge(setup, setup.PlayerName);

            // Introduce the last puzzle

            Console.WriteLine("The orb grows in size and turns into an amalgamation of every faceless person you've seen so far. You can't even call it an orb anymore; it's a monster now. \nYou have a feeling this is the final challenge you have to face!");
            Dungeon.Dungeon4Challenge(setup, setup.PlayerName);
        }

        public static void GameplayState2(Setup setup)
        {

            // Introduce the first puzzle

            setup.Savepoint++;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You land in the basement of the house. Reality itself is warping. \nThe raygun from earlier begins to glow in your pocket. \nYou feel the cracks in time calling you.");
            Dungeon.Dungeon1Challenge(setup, setup.PlayerName);

            // Introduce the second puzzle

            Console.WriteLine("The woman notices your presence. \"{0}! Where have you been? I made your favorite cookies!");
            Dungeon.Dungeon2Challenge(setup, setup.PlayerName);

            // Introduce the third puzzle

            Console.WriteLine("After running for a while, you come across an orb on a pedestal. It's warm glow reaches out to you...");
            Dungeon.Dungeon3Challenge(setup, setup.PlayerName);

            // Introduce the last puzzle

            Console.WriteLine("The orb grows in size and turns into an amalgamation of every faceless person you've seen so far. You can't even call it an orb anymore; it's a monster now. \nYou have a feeling this is the final challenge you have to face!");
            Dungeon.Dungeon4Challenge(setup, setup.PlayerName);
        }

        public static void GameplayState3(Setup setup)
        {
            // Introduce the second puzzle

            setup.Savepoint++;
            Console.WriteLine("The woman notices your presence. \"{0}! Where have you been? I made your favorite cookies!");
            Dungeon.Dungeon2Challenge(setup, setup.PlayerName);

            // Introduce the third puzzle

            Console.WriteLine("After running for a while, you come across an orb on a pedestal. It's warm glow reaches out to you...");
            Dungeon.Dungeon3Challenge(setup, setup.PlayerName);

            // Introduce the last puzzle

            Console.WriteLine("The orb grows in size and turns into an amalgamation of every faceless person you've seen so far. You can't even call it an orb anymore; it's a monster now. \nYou have a feeling this is the final challenge you have to face!");
            Dungeon.Dungeon4Challenge(setup, setup.PlayerName);
        }

        public static void GameplayState4(Setup setup)
        {
            // Introduce the third puzzle

            setup.Savepoint++;
            Console.WriteLine("After running for a while, you come across an orb on a pedestal. It's warm glow reaches out to you...");
            Dungeon.Dungeon3Challenge(setup, setup.PlayerName);

            // Introduce the last puzzle

            Console.WriteLine("The orb grows in size and turns into an amalgamation of every faceless person you've seen so far. You can't even call it an orb anymore; it's a monster now. \nYou have a feeling this is the final challenge you have to face!");
            Dungeon.Dungeon4Challenge(setup, setup.PlayerName);
        }

        public static void GameplayState5(Setup setup)
        {
            // Introduce the last puzzle

            setup.Savepoint++;
            Console.WriteLine("The orb grows in size and turns into an amalgamation of every faceless person you've seen so far. You can't even call it an orb anymore; it's a monster now. \nYou have a feeling this is the final challenge you have to face!");
            Dungeon.Dungeon4Challenge(setup, setup.PlayerName);
        }

    }
}
