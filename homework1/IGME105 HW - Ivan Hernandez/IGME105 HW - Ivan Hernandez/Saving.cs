using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwAdventureGame
{
    internal class DM
    {
        // Initialize the save file
        public static void DInit(string ts)
        {
            try
            {
                // Create the directory
                string dir = System.IO.Directory.GetCurrentDirectory();
                DirectoryInfo dy;
                dy = Directory.CreateDirectory(dir);
                Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(dir));
                // Create the file
                StreamWriter sw = new StreamWriter(dir + "\\data.csv");
                // Add the values
                sw.WriteLine(ts);
                // Close the stream and let the user know it was successful
                sw.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("Something went wrong during the initialization process.");
            }

        }

        // Write to the save w/data 

        public static void DWrite(string ts)
        {
            try
            {
                // Find the file
                string dir = System.IO.Directory.GetCurrentDirectory();
                // Create the file
                StreamWriter sw = new StreamWriter(dir + "\\data.csv");
                // Add the values
                sw.WriteLine(ts);
                // Close the stream and let the user know it was successful
                sw.Close();
                Console.WriteLine("Data saved.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong during the initialization process.");
            }

        }

        // Read the current save point from the file

        public static int DReadSaveData()
        {
            int savepoint = 0;
            try
            {
                // Open the file
                    string dir = System.IO.Directory.GetCurrentDirectory();
                    StreamReader sr = new StreamReader(dir + "\\data.csv");
                // Get all of the strings
                    List<string> Values = new List<string>();
                    string line = "";
                    int i = 0;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Values.Add(line);
                        i++;
                    }
               // Parse the values
                   savepoint = CV.CVNumber(Values[0],"Integer could not be parsed."); 
            }
            catch(Exception ex)
            {
                Console.WriteLine("Something went wrong during the reading process.");
            }

            return savepoint;
        }

        // Read the tostring from a save

        public static string DReadTS()
        {
            string ts = "";
            try
            {
                // Open the file
                string dir = System.IO.Directory.GetCurrentDirectory();
                StreamReader sr = new StreamReader(dir + "\\data.csv");
                // Get all of the strings
                List<string> Values = new List<string>();
                string line = "";
                int i = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    Values.Add(line);
                    i++;
                }
                // Parse the values
                ts = Values[0];
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong during the reading process.");
            }

            return ts;
        }




    }
}
