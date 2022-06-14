using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercizeOnArrayListCollections
{
    internal class Que4
    {
        static void Main(string[] args)
        {
            /*4.Create ArrayList of T20 Players. 
                Create a class Player (playerid, Name, Country, team)
                e.g.(1,”MSDhoni”,”India”,”Chennai Super Kings”)*/
            Console.Write("Enter the player id : ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter player name : ");
            string PlayerName = Console.ReadLine();

            Console.Write("Enter country of this player : ");
            string Country = Console.ReadLine();

            Console.Write("Enter the IPL team of this player : ");
            string IPLteam = Console.ReadLine();

            PlayerDetail.Detail(id, PlayerName, Country, IPLteam);
        }
    }
    class PlayerDetail
    {
        public static void Detail(int a, string name, string country, string IPL)
        {
            int id = a;
            string PlayerName = name;
            string Country = country;
            string IPLteam = IPL;

            ArrayList al = new ArrayList();
            al.Add(id);
            al.Add(PlayerName);
            al.Add(Country);
            al.Add(IPLteam);

            Console.Write("ArrayList of T20 player is : ");
            foreach (var s in al)
            {
                Console.Write(s + " ");
            }

            Console.ReadLine();
        }
    }
    public class AA
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Aditya");
        }
    }
}

