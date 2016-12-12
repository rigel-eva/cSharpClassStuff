using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace Project_2___LINQ
{
    class Program
    {
        static Player[] players;
        static Pokémon[] pokemon;
        static owner[] ownership;
        static void Main(string[] args)
        {
            //Setting up our Arrays ...
            players=new Player[8];
            //Shouldn't we really be assingning numerical ids numerically?
            players[0] = new Player("Bradley", 1, "pacprof", "Chicago", true);
            players[1] = new Player("Clayton", 2, "pokechamp", "Chicago", false);
            players[2] = new Player("Tina", 3, "pikachu", "Chicago", true);
            players[3] = new Player("James", 4, "ilikethis", "Kansas City", true);
            players[4] = new Player("Timothy", 5, "noname", "Tampa Bay", false);
            players[5] = new Player("Gerald", 6, "someguy", "Las Vegas", true);
            players[6] = new Player("Alex", 7, "nomoreideas", "Seatlle", true);
            players[7] = new Player("Bill", 8, "serouslynone", "Kansas City", false);
            pokemon = new Pokémon[8];
            pokemon[0] = new Pokémon("Bulbasaur", 1, 120, 130);
            pokemon[1] = new Pokémon("Squirtle", 2, 130, 120);
            pokemon[2] = new Pokémon("Rattata", 3, 110, 140);
            pokemon[3] = new Pokémon("Pickachu", 4, 110, 150);
            pokemon[4] = new Pokémon("Jigglypuff", 5, 90, 160);
            pokemon[5] = new Pokémon("Jynx", 6, 50, 200);
            pokemon[6] = new Pokémon("Ditto", 7, 220, 30);
            pokemon[7] = new Pokémon("Seaking", 8, 150, 100);
            ownership = new owner[21];
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
            pokeQuery();
        }
        //1. Print out the contents of all arrays
        static void printArrays()
        {
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
        }
        //2. Get a city name, then using a query display all player nicknames from that city
        static void cityQuary()
        {
            Console.Write("Please input a City Name: ");
            string cityName = Console.ReadLine();
            var cityQuary = from player in players where player.city.ToLower() == cityName.ToLower() select player.idName;
            Console.WriteLine("Player Nicknames who are in " + cityName + ": ");
            foreach (var nickname in cityQuary)
            {
                Console.WriteLine("  " + nickname);
            }
        }
        //3. Get an attack value the using a query display all pokemon with attack values greater than or equal to said attack value
        static void attackValue()
        {
            uint attackValue;
            do
            {
                Console.Write("Please input an Attack value:");
            }
            while (!uint.TryParse(Console.ReadLine(), out attackValue));
            //ok, increadbly long story short, this query gets all pokemon above a certian attack value, and gives us a string back with the name and the attack value.
            var attackQuary = from poke in pokemon where poke.attack >= attackValue orderby poke.attack descending select "pokemon name: " + poke.name + "\n  Attack Value: " + poke.attack;
            foreach (string poke in attackQuary)
            {
                Console.WriteLine(poke);
            }
        }
        //4. do the same thing that we did with attack values for defense values ...
        static void defenseValue()
        {
            uint defenseValue;
            do
            {
                Console.Write("Please input an Defense value:");
            }
            while (!uint.TryParse(Console.ReadLine(), out defenseValue));
            //ok, increadbly long story short, this query gets all pokemon above a certian attack value, and gives us a string back with the name and the attack value.
            var defenseQuary = from poke in pokemon where poke.defense >= defenseValue orderby poke.defense descending select "pokemon name: " + poke.name + "\n  Defense Value: " + poke.defense;
            foreach (string poke in defenseQuary)
            {
                Console.WriteLine(poke);
            }
        }
        //5. get a player string value||id and display a list of pokemon owned, and their corisponding values 
        static void pokeQuery()
        {
            Console.Write("Please input a player name || nickname || id number: ");
            string playerData = Console.ReadLine();//Get our query target
            string pokeQuery="";
            uint playerID;
            if (!uint.TryParse(playerData, out playerID))//If we didn't recieve a valid player id ...
            {
                //let's try to grab one!
                var pQuery = from player in players where player.name == playerData || player.idName == playerData select player;
                foreach(Player player in pQuery)
                {
                    playerID = player.id;
                    break;//WE ONLY want to run this loop once ...
                }
            }
            //get all pokemon for that player.
            IEnumerable<owner> playerQuery = from own in ownership where playerID == own.playerID select own;
            foreach (owner own in playerQuery)
            {
                var boop = from poke in pokemon where poke.id == own.pokémonID select poke.name;
                foreach (string bo in boop)//Should only trigger once ...
                {
                    pokeQuery += bo;
                    pokeQuery += " Level: " + own.level + "\n";
                }
            }
            Console.WriteLine(pokeQuery);

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
