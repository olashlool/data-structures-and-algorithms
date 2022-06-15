using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Left_Join
{
    public class Hashtable
    {
        public long Size { get; set; } // The size of the HashTable array.
        public LinkedList[] Table { get; set; } // The array making up the HashTable.
        public Hashtable(int size) // Constructor method to instantiate a new HashTable.
        {
            Size = size;
            Table = new LinkedList[size];
        }

        public int Hash(Object key)
        {
            string keyString = key.ToString();
            long num = 1;
            foreach (char item in keyString)
            {
                num *= item;
            }
            int idx = (int)(num * 599 % Size);
            return idx;
        }
        public void Set(string key, string value)
        {
            long index = Hash(key);
            if (Table[index] == null)
            {
                Table[index] = new LinkedList();
            }
            if (Get(key) == null)
            {
                Table[index].Append(key, value);
            }
        }

        public Object Get(Object key)
        {
            int index = Hash(key);
            if (Table[index] == null)
            {
                return null;
            }
            return Table[index].Find(key);
        }

        public List<string> LeftJoin(Hashtable mapA, Hashtable mapB)
        {
            List<string> list = new List<string>();
            string temp = "";
            foreach (LinkedList item in mapA.Table)
            {
                if (item != null)
                {
                    item.Current = item.Head;
                    while (item.Current != null)
                    {
                        temp = (string)(mapB.Get(item.Current.Key)) ?? "NULL";
                        temp = $"{(string)item.Current.Key}, {(string)item.Current.Value}, {temp}";
                        list.Add(temp);
                        temp = "";
                        item.Current = item.Current.Next;
                    }
                }
            }
            return list;
        }
    }
}
