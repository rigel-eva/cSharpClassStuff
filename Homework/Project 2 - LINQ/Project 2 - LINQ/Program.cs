using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2___LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Setting up our Arrays ...
            Player[] players=new Player[8];
            //Shouldn't we really be assingning numerical ids numerically?
            players[0] = new Player("Bradley", 1, "pacprof", "Chicago", true);
            players[1] = new Player("Clayton", 2, "pokechamp", "Chicago", false);
            players[2] = new Player("Tina", 3, "pikachu", "Chicago", true);
            players[3] = new Player("James", 4, "ilikethis", "Kansas City", true);
            players[4] = new Player("Timothy", 5, "noname", "Tampa Bay", false);
            players[5] = new Player("Gerald", 6, "someguy", "Las Vegas", true);
            players[6] = new Player("Alex", 7, "nomoreideas", "Seatlle", true);
            players[7] = new Player("Bill", 8, "serouslynone", "Kansas City", false);
            Pokémon[] pokemon = new Pokémon[8];
            pokemon[0] = new Pokémon("Bulbasaur", 1, 120, 130);
            pokemon[1] = new Pokémon("Squirtle", 2, 130, 120);
            pokemon[2] = new Pokémon("Rattata", 3, 110, 140);
            pokemon[3] = new Pokémon("Pickachu", 4, 110, 150);
            pokemon[4] = new Pokémon("Jigglypuff", 5, 90, 160);
            pokemon[5] = new Pokémon("Jynx", 6, 50, 200);
            pokemon[6] = new Pokémon("Ditto", 7, 220, 30);
            pokemon[7] = new Pokémon("Seaking", 8, 150, 100);
            owner[] ownership = new owner[21];
            ownership[0] = new owner(1, 1, 11, 1);
            ownership[1] = new owner(1, 5, 9, 2);
            ownership[2] = new owner(1, 7, 5, 1);
            ownership[3] = new owner(2, 2, 32, 1);
            ownership[4] = new owner(2, 4, 2, 1);
            ownership[5] = new owner(3, 3, 43, 1);
            ownership[6] = new owner(3, 8, 1, 3);
            ownership[7] = new owner(3, 7, 15, 1);
            ownership[8] = new owner(3, 2, 22, 1);
            ownership[9] = new owner(4, 4, 4, 1);
            ownership[10] = new owner(4, 5, 2, 1);
            ownership[11] = new owner(5, 5, 1, 1);
            ownership[12] = new owner(5, 6, 1, 10);
            ownership[13] = new owner(6, 6, 1, 1);
            ownership[14] = new owner(6, 1, 2, 2);
            ownership[15] = new owner(6, 3, 3, 1);
            ownership[16] = new owner(6, 8, 5, 1);
            ownership[17] = new owner(6, 7, 7, 1);
            ownership[18] = new owner(6, 2, 11, 1);
            ownership[19] = new owner(7, 7, 8, 1);
            ownership[20] = new owner(8, 8, 9, 1);
            //1. Printing out the Arrays
            Console.WriteLine("Contents of PLAYERS array:");
            foreach (Player player in players)
            {
                Console.WriteLine(player);
            }
            Console.WriteLine("\n\nContents of POKEMON array:");
            foreach(Pokémon pok in pokemon)
            {
                Console.WriteLine(pok);
            }
            Console.WriteLine("\n\nContents of OWNERSHIP array:");
            foreach(owner own in ownership)
            {
                Console.WriteLine(own);
            }
            //2. Get a city name, then using a query display all player nicknames from that city
            Console.Write("Please input a City Name: ");
            string cityName = Console.ReadLine();
            var cityQuary = from player in players where player.city.ToLower() == cityName.ToLower() select player.idName;
            Console.WriteLine("Player Nicknames who are in " + cityName + ": ");
            foreach (var nickname in cityQuary)
            {
                Console.WriteLine("  "+nickname);
            }
        }
    }
    class Player
    {
        public string name;
        public uint id;
        public string idName;
        public string city;
        public bool PAID_UP;
        public Player()
        {
            PAID_UP = false;
        }
        public Player(string _name, uint _id, string _idName, string _city, bool paid_up)
        {
            name = _name;
            id = _id;
            idName = _idName;
            city = _city;
            PAID_UP = paid_up;
        }
        public override string ToString()
        {
            return "Player: "+name + "(" + idName + ":" + id + ")" + "\n  City: " + city + "\n  PAID_UP: " + PAID_UP;
        }
    }
    class Pokémon
    {
        public string name;
        public uint id;
        public uint attack;
        public uint defense;
        public Pokémon(string _name, uint _id, uint _attack, uint _defense)
        {
            name = _name;
            id = _id;
            attack = _attack;
            defense = _defense;
        }
        public override string ToString()
        {
            return "Pokémon: "+name+"("+id + ")\n  Attack:" + attack + "\n  Defense:" + defense;
        }
    }
    class owner
    {
        public uint playerID;
        public uint pokémonID;
        public uint level;
        public uint numberOwned;
        public owner(uint _playerID, uint _pokémonID, uint _level, uint _numberOwned)
        {
            playerID = _playerID;
            pokémonID = _pokémonID;
            level = _level;
            numberOwned = _numberOwned;
        }
        public override string ToString()
        {
            return "Ownership:\n  Player ID: " + playerID+ "\n  Pokémon ID: " + pokémonID + "\n  Level: " + level + "\n  Number Owned: " + numberOwned;
        }
    }
}
