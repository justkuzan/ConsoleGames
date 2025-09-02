internal class Program
{
    static void Main()
    {
        char[,] map = null;
        string[] file = File.ReadAllLines("map.txt");
        Console.WriteLine(file[0]);
    }

    private static char[,] ReadMap(string path)
    {
        string[] file = File.ReadAllLines(path);
        
    }
}