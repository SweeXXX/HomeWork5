enum State
{
    Empty,
    Wall,
    Visited
};

public class Program
{
    static void Visit(State[,] map, int x, int y)
    {
        if (x < 0 || x >= map.GetLength(0) || y < 0 || y >= map.GetLength(1)) return;
        if (map[x, y] != State.Empty) return;
        map[x, y] = State.Visited;
        Print(map);

        Visit(map, x + 1, y);
        Visit(map, x, y - 1);
        Visit(map, x - 1, y);
        Visit(map, x, y + 1);


    }

    static void Main()
    {
        var map = new State[labyrinth[0].Length, labyrinth.Length];

        for (int x = 0; x < map.GetLength(0); x++)
            for (int y = 0; y < map.GetLength(1); y++)
                map[x, y] = labyrinth[y][x] == ' ' ? State.Empty : State.Wall;

        Print(map);
        Visit(map, 0, 0);
    }

    static string[] labyrinth = new string[]
    {
        " █   █    ",
        " █ █████ █",
        "      █   ",
        "████ ███ █",
        "         █",
        " ███ █████",
        " █        ",
    };

    static void Print(State[,] map)
    {

        Console.CursorLeft = 0;
        Console.CursorTop = 0;
        for (int x = 0; x < map.GetLength(0) + 2; x++)
            Console.Write("█");
        Console.WriteLine();
        for (int y = 0; y < map.GetLength(1); y++)
        {
            Console.Write("█");
            for (int x = 0; x < map.GetLength(0); x++)
                switch (map[x, y])
                {
                    case State.Wall: Console.Write("█"); break;
                    case State.Empty: Console.Write(" "); break;
                    case State.Visited: Console.Write("0"); break;
                }
            Console.WriteLine("█");
        }
        for (int x = 0; x < map.GetLength(0) + 2; x++)
            Console.Write("█");
        Console.ReadKey();
    }
}