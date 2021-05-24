using System;

namespace project
{
    public class GameLogic
    {
        static public int loopNumber = 0;
        static public int delay = 30;
        static public string textColor = "Magenta";
        static public int currentRoom = 1;
        static public bool conquered = false;
        static public bool play = true;
    }

    public class Room
    {
        public bool clear1;
        public bool clear2;
        public bool clear3;
        public bool specialInteraction;

        public Room(bool _clear1 = false, bool _clear2 = false, bool _clear3 = false, bool _specialInteraction = false)
        {
            clear1 = _clear1;
            clear2 = _clear2;
            clear3 = _clear3;
            specialInteraction = _specialInteraction;
        }
    }

    public class StaticRoom
    {
        public static Room room1 = new Room();
        public static Room room2 = new Room();
        public static Room room3 = new Room();
        public static Room room4 = new Room();
        public static Room room5 = new Room();
        public static Room room6 = new Room();
        public static Room room7 = new Room();
        public static Room room8 = new Room();
        public static Room room9 = new Room();
    }

    public class Base
    {
        public int health;
        public int shield;
        public int attack;
        public double defense;
        public int crit;
        public bool alive = true;

    }

    public class Player : Base
    {
        public int maxhealth;
        public int stupidity = 0;
        public bool hasChestKey = false;
        public bool subjectOfLordBacon = false;
        public bool chooseShield = false;
        public bool hasMeat = false;
        public bool brokenChestKey = false;
        public bool hasBossKey = false;
        public bool hasTrueKey = false;

        public Player(int _health = 100, int _maxhealth = 100, int _shield = 0, int _attack = 1, double _defense = 1, int _crit = 10)
        {
            health = _health;
            maxhealth = _maxhealth;
            shield = _shield;
            attack = _attack;
            defense = _defense;
            crit = _crit;
        }

    }

    public class StaticPlayer
    {
        public static Player player = new Player();
    }
    public class StaticEnemies
    {
        public static Goblin goblin1 = new Goblin(20, 10, 5, 0.95, 5);
        public static Goblin goblin2 = new Goblin();
        public static HobGoblin hobgoblin = new HobGoblin();
        public static Wolf wolf = new Wolf();
        public static Dragonling Smedd = new Dragonling();
    }

    public class Goblin : Base
    {
        public Goblin(int _health = 25, int _shield = 50, int _attack = 10, double _defense = 0.8, int _crit = 20)
        {
            health = _health;
            shield = _shield;
            attack = _attack;
            defense = _defense;
            crit = _crit;
        }
    }
    public class HobGoblin : Base
    {
        public HobGoblin(int _health = 50, int _shield = 25, int _attack = 5, double _defense = 0.50, int _crit = 5)
        {
            health = _health;
            shield = _shield;
            attack = _attack;
            defense = _defense;
            crit = _crit;
        }
    }
    public class Dragonling : Base
    {
        public Dragonling(int _health = 200000, int _shield = 200000, int _attack = 1000000, double _defense = 0.000001, int _crit = 100)
        {
            health = _health;
            shield = _shield;
            attack = _attack;
            defense = _defense;
            crit = _crit;
        }
    }
    public class Wolf : Base
    {
        public Wolf(int _health = 50, int _shield = 25, int _attack = 10, double _defense = 0.80, int _crit = 10)
        {
            health = _health;
            shield = _shield;
            attack = _attack;
            defense = _defense;
            crit = _crit;
        }
    }
}