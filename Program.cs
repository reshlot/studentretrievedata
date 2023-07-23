using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StudentDataRetrieval
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Path to the text file
            string filePath = "D:\\Simplilearn\\Main Projects\\Student_data.txt";

            // Check if the file exists
            if (File.Exists(filePath))
            {
                // Read all lines from the file
                string[] lines = File.ReadAllLines(filePath);

                // Display the student data
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("Student data file not found!");
            }

            Console.ReadLine();
        }
    }
}
    