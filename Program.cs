using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3
{
    class Program
    {
        static void PrintSpaces(int level)
        //function for displaying the spaces 
        {
            for (int i = 0; i < level; i++)
                Console.Write("  ");
        }

        static void Ex4(DirectoryInfo directory, int level)
        {
            FileInfo[] files = directory.GetFiles();
            //array which save and return all files from given directory 
            DirectoryInfo[] directories = directory.GetDirectories();
            //array which save and return all directories  from given directory 

            foreach (FileInfo file in files)
            //iterate all files from the array files for displaying the files 
            {
                PrintSpaces(level); // go to function printspaces
                Console.WriteLine(file.Name); // display file name
            }

            foreach (DirectoryInfo d in directories)
            //iterate all folders/directories from the array directories 
            {
                PrintSpaces(level); // print the space 
                Console.WriteLine(d.Name); // display the name of folder
                Ex4(d, level + 1); // RECURSION --> go to function Ex4 again
            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo(@"C:\doo");
            // specify the directories which we will manipulate
            Ex4(d, 0); // give the initioal parameters to function Ex4
            Console.ReadKey();
        }
    }
}