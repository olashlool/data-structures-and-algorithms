using Compare_Two_File_Directories.Classes;
using System;

namespace Compare_Two_File_Directories
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory compareTwoDirectory = new Directory();

            Directory directoryOne = new Directory();
            directoryOne.Root = new Node("folder 01");
            directoryOne.Root.Left = new Node("folder 02");
            directoryOne.Root.Right = new Node("folder 03");
            directoryOne.Root.Left.Left = new Node(".js");
            directoryOne.Root.Left.Right = new Node(".py");
            directoryOne.Root.Right.Left = new Node(".cs");
            directoryOne.Root.Right.Right = new Node(".java");

            Directory directoryTwo = new Directory();
            directoryTwo.Root = new Node("folder 04");
            directoryTwo.Root.Left = new Node("folder 05");
            directoryTwo.Root.Right = new Node("folder 06");
            directoryTwo.Root.Left.Left = new Node(".py");
            directoryTwo.Root.Left.Right = new Node(".py");
            directoryTwo.Root.Right.Right = new Node("folder 07");
            directoryTwo.Root.Right.Right.Left = new Node(".cs");
            directoryTwo.Root.Right.Right.Right = new Node(".js");

            Console.WriteLine(compareTwoDirectory.CompareTwoDirectories(directoryOne, directoryTwo));
        }
    }
}
