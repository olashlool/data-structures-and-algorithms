using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare_Two_File_Directories.Classes
{
    class Directory
    {
        public Node Root { get; set; }
        public int TotalCount { get { return LeafsCount(Root); } }

        public int LeafsCount(Node folder)
        {
            if (folder == null) return 0;
            else if (folder.Left == null && folder.Right == null) return 1;
            else return LeafsCount(folder.Left) + LeafsCount(folder.Right);
        }
        public bool CompareTwoDirectories(Directory folderOne, Directory folderTwo)
        {
            int CountFolderOne = folderOne.TotalCount;
            int CountFolderTwo = folderTwo.TotalCount;

            if (CountFolderOne == CountFolderTwo) return true;
            else return false;
        }

        public bool mutaz(Node folderOne, Node folderTwo)
        {
            int CountFolderOne = 0;
            int CountFolderTwo = 0;

            if (folderOne == null) CountFolderOne= 0;
            else if (folderOne.Left == null && folderOne.Right == null) CountFolderOne++;


            if (folderTwo == null) CountFolderTwo = 0;
            else if (folderTwo.Left == null && folderTwo.Right == null) CountFolderTwo++;


            mutaz(folderOne.Left, folderTwo.Left);
            mutaz(folderOne.Right, folderTwo.Right);


            //else return LeafsCount(folderOne.Left) + LeafsCount(folderOne.Right);

            if (CountFolderOne == CountFolderTwo) return true;
            else return false;
        }
    }
}
