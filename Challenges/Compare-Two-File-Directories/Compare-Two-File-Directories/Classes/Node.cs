using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare_Two_File_Directories.Classes
{
    class Node
    {
        public string FolderName { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(string folderName)
        {
            FolderName = folderName;
            Left = Right = null;
        }
    }
}
