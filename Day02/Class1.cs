
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book
{

    class stud : IComparable<stud>
    {
        int bid;
        string nm;
        int price;

        public stud(int bid, string nm, int price)
        {
            this.Sid = bid;
            this.Nm = nm;
            this.price = price;
        }

        public int Sid { get => bid; set => bid = value; }
        public string Nm { get => nm; set => nm = value; }
        public int Persontage { get => price; set => price = value; }

        public int CompareTo(stud other)
        {
            if (this.price > other.price)
                return 1;
            else if (this.price < other.price)
                return -1;
            else
                return 0;
        }
    }
    class Abc
    {
        static void Main(string[] args)
        {
            SortedList<stud, string> ss = new SortedList<stud, string>();
            ss.Add(new stud(1, "akp", 200), "C#");
            ss.Add(new stud(2, "abc", 120), "java");


            foreach (KeyValuePair<stud, string> e in ss)
                Console.WriteLine(e.Key + "===>" + e.Value);
        }
    }


}