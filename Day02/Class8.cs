using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercizeOnArrayListCollections;

namespace New
{
    internal class Custom
    {
        //2.Sort Arraylist of String in reverse order of its natural
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(new Stud(1, "om"), 7776926452);
            ht.Add(new Stud(1, "om"), 7776926452);
            ht.Add(new Stud(1, "om"), 7776926452);
            ht.Add(new Stud(1, "om"), 7776926452);
            foreach (DictionaryEntry d in ht)
                Console.WriteLine(d.Key + "=>" + d.Value);
        }
    }

    internal class CustomerA
    {

        static void Main(string[] args)
        {
            Stack st = new Stack();
            st.Push("om");
            st.Push("karan");
            st.Push("raj");
            foreach (object ob in st)
                Console.WriteLine(ob);

            string d = (string)st.Pop();
            Console.WriteLine("Removed=====>" + d);
            Console.WriteLine("Peek: " + st.Peek());
            foreach (object ob in st)
                Console.WriteLine(ob);
        }
    }

}

