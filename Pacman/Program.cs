internal class Program
{
    static void Main()
    {
        char[,] map = ReadMap("map.txt");

        while (true)
        {
            Console.Clear();
            
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            DrawMap(map);
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(1, 1);
            Console.Write("@");

            Thread.Sleep(1000);
        }
    }

    private static char[,] ReadMap(string path)
    {
        string[] file = File.ReadAllLines(path);
        char[,] map = new char[GetMaxLengthOfLine(file), file.Length];

        for (int x = 0; x < map.GetLength(0); x++)
            for (int y = 0; y < map.GetLength(1); y++)
                map[x, y] = file[y][x];
        return map;
    }

    private static void DrawMap(char[,] map)
    {
        for (int y = 0; y < map.GetLength(1); y++)
        {
            for (int x = 0; x < map.GetLength(0); x++)
            {
                Console.Write(map[x, y]);
            }
            Console.Write("\n");
        }
    }

    private static int GetMaxLengthOfLine(string[] lines)
    {
        int maxLength = lines[0].Length;

        foreach (var line in lines)
            if (line.Length > maxLength)
                maxLength = line.Length;
        
        return maxLength;
    }
}