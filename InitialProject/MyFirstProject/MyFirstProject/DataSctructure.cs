using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MyThirdProject
{
    class DataSctructure
    {
        public Dictionary<int, string> dictionary;
        public HashSet<int> hashSet;
        public SortedList<int, string> sortedList;
        public SortedSet<int> sortedSet;
        public List<int> list;
        public LinkedList<int> linkedList;
        public KeyValuePair<int, string> pair;

        public void fillDictionary()
        {
            this.dictionary.Add(1, "Ola1");
            this.dictionary.Add(2, "Ola2");
            this.dictionary.Add(3, "Ola3");
            this.dictionary.Add(4, "Ola4");
            this.dictionary.Add(5, "Ola5");
            this.dictionary.Add(6, "Ola6");
        }

        public void fillPair()
        {
            this.pair = new KeyValuePair<int, string>(23, "Ola23");
            this.dictionary.Add(this.pair.Key,this.pair.Value);
        }

        public void fillTheStructures()
        {
            fillDictionary();
            fillPair();
        }

        public DataSctructure()
        {
            this.dictionary = new Dictionary<int, string>();
            this.hashSet = new HashSet<int>();
            this.sortedList = new SortedList<int, string>();
            this.sortedSet = new SortedSet<int>();
            this.list = new List<int>();
            this.linkedList = new LinkedList<int>();
            this.pair = new KeyValuePair<int, string>();

            fillTheStructures();

            
        }
    }
}
