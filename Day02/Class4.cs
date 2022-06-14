using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

namespace BB
{
    public class person
    {
        string name;
        ArrayList hobbies;
        public person(string name, ArrayList hobbies)
        {
            this.Name = name;
            this.Hobbies = hobbies;

        }
        public string Name { get => name; set => name = value; }
        public ArrayList Hobbies { get => hobbies; set => hobbies = value; }

    }

    class TestPerson
    {
        static void Main(string[] args)
        {
            ArrayList plist = new ArrayList();
            do
            {
                Console.WriteLine("Enter a name");
                string nm = Console.ReadLine();
                Console.WriteLine("Enter hobbies");
                int c = int.Parse(Console.ReadLine());
                ArrayList hobbiesList = new ArrayList();
                for (int i = 0; i < c; i++)
                {
                    Console.WriteLine($"{nm} Enter hobbies");
                    string h = Console.ReadLine();
                    hobbiesList.Add(h);
                }
                person p = new person(nm, hobbiesList);
                object p1 = plist.Add(p);
                Console.WriteLine("Do you want to add one or more");
                string choice = Console.ReadLine().ToLower();
                if (choice == "no") ;
                break;

            } while (true);
        }
    }


    class class2
    {
        static void Main(string[] args)
        {

            List<int> al = new List<int>();
            al.Add(20);
            al.Add(90);
            Console.WriteLine(al[0]);
           // List<Stud> al2 = new List<Stud>();

            Dictionary<int, String> d1 = new Dictionary<int, String>();
            d1.Add(23, "om");
            d1.Add(890, "Ram");

            Console.WriteLine(d1.ContainsKey(25));
            Console.WriteLine(d1.ContainsValue("Ram"));
            d1[23] = "Ketaki";
            d1.Remove(23);
            foreach (KeyValuePair<int, String> k in d1)
                Console.WriteLine(k.Key + "=>" + k.Value);
            foreach (int a in d1.Keys)
                Console.WriteLine(a + "=>" + d1[a]);

        }
    }
    class Demo
    {
        static void Main(string[] args)
        {
            LinkedList<int> ll = new LinkedList<int>();
            ll.AddLast(23);
            ll.AddLast(45);
            ll.AddLast(65);
            ll.AddFirst(20);

            foreach (int d in ll)
                Console.WriteLine(d);
            LinkedListNode<int> n1 = ll.Find(90);
            ll.AddAfter(n1, new LinkedListNode<int>(900));

            foreach (int d in ll)
                Console.WriteLine(d);
        }
    }

    class TestPerson1
    {
        static void Main(string[] args)
        {
            SortedList<string, int> ss = new SortedList<string, int>();
            ss.Add("Ketaki", 90);
            ss.Add("Aditya", 90);
            ss.Add("Sonam", 90);
            ss.Add("Amit", 90);

            foreach (KeyValuePair<string, int> e in ss)
                Console.WriteLine(e.Key + "===>" + e.Value);
        }
    }

    class stud : IComparable<stud>
    {
        int sid;
        string nm;
        int persontage;

        public stud(int sid, string nm, int persontage)
        {
            this.Sid = sid;
            this.Nm = nm;
            this.Persontage = persontage;
        }

        public int Sid { get => sid; set => sid = value; }
        public string Nm { get => nm; set => nm = value; }
        public int Persontage { get => persontage; set => persontage = value; }

        int IComparable<stud>.CompareTo(stud? other)
        {
            throw new NotImplementedException();
        }
    }
    class SortstudBypercent : IComparer<stud>
    {
        public int Compare(stud s1, stud s2)
        {
            Console.WriteLine("in compare");
            return s2.Persontage.CompareTo(s1.Persontage);
        }
    }
    class SortstudByID : IComparer<stud>
    {
        public int Compare(stud s1, stud s2)
        {
            Console.WriteLine("in compare");
            return s1.Sid.CompareTo(s2.Sid);
        }
    }
    class demo
    {
        static void Main(string[] args)
        {
            SortedList<stud, string> ss = new SortedList<stud, string>(new SortstudBypercent());
            ss.Add(new stud(1, "Aditya", 95), "java");
            ss.Add(new stud(2, "Nikhil", 85), "java");
            ss.Add(new stud(3, "udhhav", 75), "java");
            ss.Add(new stud(4, "amit", 88), "java");

            foreach (KeyValuePair<stud, string> k in ss)
                Console.WriteLine(k.Key + "==>" + k.Value);
        }
    }

}

