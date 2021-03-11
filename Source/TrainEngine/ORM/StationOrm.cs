using System;
using System.Collections.Generic;
using System.Text;

namespace TrainEngine.ORM
{
    class StationOrm
    {
        static void Main()
        {
            // The files used in this example are created in the topic
            // How to: Write to a Text File. You can change the path and
            // file name to substitute text files of your own.

            // Example #1
            // Read the file as one string.
            string text = System.IO.File.ReadAllText(@"C:\Users\drunn\Documents\GitHub\the-train-track-kom-in-mathcen\Data\station.txt");

            // Display the file contents to the console. Variable text is a string.
            Console.WriteLine("Contents of WriteText.txt = {0}", text);

            // Example #2
            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\drunn\Documents\GitHub\the-train-track-kom-in-mathcen\Data\station.txt");

            // Display the file contents by using a foreach loop.
            Console.WriteLine("Contents of WriteLines2.txt = ");
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                Console.WriteLine("\t" + line);
            }

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
