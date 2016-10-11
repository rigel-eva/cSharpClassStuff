using System;

namespace _16._10._10
{
    class Program
    {
        enum NAMES
        {
            SNAKE_EYES=2,

        }
        static IComparable Maximum(IComparable  a, IComparable b)//Ok, interfaces are a thing in C# ... now how the hell do I use them ...
        {
            return (a.CompareTo(b)<0) ? a : b;//And here comes the single line ifs ... oh no ...
        }
        static void Main(string[] args)
        {
            //Console.Write(3.CompareTo(5));
            //Maximum(3,5);
            player p1 = new player();
            System.Threading.Thread.Sleep(100);//Need a bit of a wait to just have two random seeds ... no sense in having the players use the same dice
            player p2 = new player();
            while (p1.alive && p2.alive)//Well, let's have these two fight!;
            {
                int attack = p2.attack(p1);
                if (attack > -1)
                {
                    Console.WriteLine("P1 Hits P2 for {0} points of damage!", attack);
                }else
                {
                    Console.WriteLine("P1 Attacks P2 ... and Misses!");
                }
                if (p2.dead)
                {
                    break;
                }
                attack = p1.attack(p2);
                if (attack > -1)
                {
                    Console.WriteLine("P2 Hits P1 for {0} points of damage!", attack);
                }
                else
                {
                    Console.WriteLine("P2 Attacks P1 ... and Misses!");
                }
            }
            if (p1.dead)
            {
                Console.WriteLine("P2 Has slain P1");
            }else
            {
                Console.WriteLine("P1 Has slain P2");
            }
        }
    }
    interface IAttackable
    {
        int hp
        {
            get;
            set;
        }
        int hit
        {
            get;
        }
        Tuple<int, int, int> damage//number of dice, dice sides, modifier
        {
            get;
        }
        int attack(IAttackable attacker);
    }
    class player:IAttackable
    {
        int _hp, _avo, _hit;
        Tuple<int, int, int> _damage;
        Random dice;
        public int hp
        {
            get
            {
                return _hp;
            }
            set
            {
                _hp = value;
            }
        }
        public int hit
        {
            get
            {
                return _hit;
            }
        }
        public Tuple <int,int,int> damage
        {
            get
            {
                return _damage;
            }
        }
        public bool dead
        {
            get
            {
                return hp <= 0;
            }
        }
        public bool alive
        {
            get
            {
                return hp > 0;
            }
        }
        public player()
        {
            _hp = 40;
            _avo = 14;
            _hit = 6;
            _damage = new Tuple<int, int, int>(2, 12, 4);
            dice = new Random();
        }
        public int attack(IAttackable attacker)
        {
            if (attacker.hit + dice.Next(1, 20) < _avo)
            {
                return -1; //attack fails, return -1;
            }
            else//Successful hit!
            {
                int returner = attacker.damage.Item3;
                for(int i=0; i<attacker.damage.Item1; i++)
                {
                    returner += dice.Next(1, attacker.damage.Item2);
                    
                }
                hp -= returner;
                return returner;
            }
        }
    }
}
