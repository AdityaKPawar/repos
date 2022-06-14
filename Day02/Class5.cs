using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercize1
{
    internal class Que2
    {
        //2.Sort Arraylist of String in reverse order of its natural
        static void Main2(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("Hashirama");
            al.Add("Tobirama");
            al.Add("Minato");
            al.Add("Saratobi");
            al.Add("Tsunade");
            al.Add("Kakashi");
            al.Add("Naruto");

            al.Sort();
            /*foreach(string s in al)
            {
                Console.Write(s + " ");
            }*/

            for (int i = al.Count - 1; i >= 0; i--)
            {
                Console.Write(al[i] + " ");
            }

            Console.ReadLine();
        }
    }
}