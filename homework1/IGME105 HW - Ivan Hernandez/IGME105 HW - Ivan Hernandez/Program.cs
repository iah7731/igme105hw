/* Name: VisoQuest
 * Creator: Ivan Hernandez
 * Purpose: Make a text-based adventure game
 * Date: 9/9/22
 * GIT REPO: 
*/

using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace HwAdventureGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Setup setup = new Setup();

            // Welcome to the game

             Setup.WelcomeToTheGame(setup);

            // Explain the game

           string Confirmation = Setup.ConfirmGame(setup.PlayerName);
            if (Confirmation == "N")
            {
                Setup.EndTheGame(setup, "Fine. Be that way.");
            }

           Gameplay.GameplayState0(setup);

        }      

    }
}
