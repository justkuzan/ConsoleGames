using System.Globalization;

class Program
{
    public static void Main()
    {
        // Console.WriteLine(name + " - " + "$" + price);
    }
}
class Guns
{
    Gun ak47 = new Gun("AK47", 2600);
    Gun ak48 = new Gun("AK47", 2600);
    Gun ak49 = new Gun("AK47", 2600);
    Gun ak410 = new Gun("AK47", 2600);
}
class Gun
{
    public string name;
    public int price;

    public Gun(string name, int price)
    {
        this.name = name;
        this.price = price;
    }

} 
