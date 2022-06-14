using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class ArrayListDemo
{
    //1.	Assume you have Arraylist  al = new ArrayList();
    //al.Add("Sun");
    //     al.Add("Mon");
    //     al.Add("Sat");
    //     al.Add("Sun ");
    //     al.Add("Mon ");
    //     al.Add("Sat ");
    //     al.Add("Sun ");
    //     al.Add("Sat ");
    //     al.Add("Sun ");
    //     al.Add("Mon ");
    //     Write a code to remove duplicate elements from above list.
    //     Final Arraylist should contain (Sun, Mon, Sat);
    public static void Main1(string[] args)
    {
        ArrayList al = new ArrayList();
        al.Add("Sun");  //0
        al.Add("Mon");  //1
        al.Add("Sat");  //2
        al.Add("Sun "); //3
        al.Add("Mon "); //4
        al.Add("Sat "); //5
        al.Add("Sun "); //6
        al.Add("Sat "); //7
        al.Add("Sun "); //8
        al.Add("Mon "); //9

        Console.Write("Original arraylist : ");
        foreach (string obj in al)
        {
            Console.Write(obj + " ");
        }

        al.RemoveRange(3, 7);
        al.Remove("Sun");
        al.Remove("Mon");
        al.Remove("Sat");

        al.RemoveAt(6);
        al.RemoveAt(7);
        al.RemoveAt(8);
        al.RemoveAt(9);

        Console.Write("\nNumber of elements in List : " + al.Count);

        Console.Write("\nArrayList After removing elements : ");
        foreach (string obj in al)
        {
            Console.Write(obj + " ");
        }

        Console.Write("\nArrayList After removing elements : ");
        for (int i = 0; i < al.Count; i++)
        {
            for (int j = 0; j < al.Count; j++)
            {
                if (al[i] == al[j])
                {
                    al.RemoveAt(i);
                    Console.Write(al[i] + " ");
                }
            }
        }

        Console.ReadLine();


    }
}