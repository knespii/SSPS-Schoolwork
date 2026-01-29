GameManager gameManager = new GameManager();
gameManager.character = new Character();
gameManager.InitializeGame();
gameManager.DrawMap();

struct Position
{
    public int x;
    public int y;

    public Position()
    {
        Random rnd = new Random();
        this.x = rnd.Next(1, GameManager.xSize);
        this.y = rnd.Next(1, GameManager.ySize);
    }
}

class Character
{
    public Position pos = new Position();
    public string name;
    public int health;
    public int level;
    public int range;
    public int damage;

    public Character(int health, int level, int range, int damage, string name = "")
    {
        this.health = health;
        this.level = level;
        this.range = range;
        this.damage = damage;
        this.name = name;
    }
}

class Enemy : Character
{
    public Enemy() : base(health: 7, level: 1, range: 1, damage: 2) { }
}

class Mage : Character
{
    public int mana;

    public Mage(string name) : base(health: 12, level: 1, range: 3, damage: 1, name: name)
    {
        this.mana = 60;
    }
}

class Melee : Character
{
    public Melee(string name) : base(health: 15, level: 1, range: 1, damage: 4, name: name)
    {
    }
}

class Archer : Character
{
    public Archer(string name) : base(health: 7, level: 1, range: 5, damage: 1, name: name)
    {
    }
}

class GameManager
{
    public static int xSize = 8;
    public static int ySize = 10;
    public Character character;
    public List<Enemy> enemies = new List<Enemy>();
    public int enemyCount = 5;

    public void InitializeGame()
    {
        for (int i = 0; i < enemyCount; i++)
        {
            Enemy enemy = new Enemy();
            enemies.Add(enemy);
        }
    }

    public void DrawMap()
    {
        Console.Clear();
        for (int i = 0; i < xSize; i++)
        {
            for (int j = 0; j < ySize; j++)
            {
                Enemy enemy = enemies.Find(e => e.pos.x == i && e.pos.y == j);
                if (character != null && character.pos.x == i && character.pos.y == j)
                {
                    Console.Write("P");
                }
                else if (enemy != null)
                {
                    Console.Write("E");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }
    }
}



