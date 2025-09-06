using System.Globalization;

class Program
{
    public static void Main()
    {
        Gun[] guns =
        {
            new Gun("AK47", 2600),
            new Gun("AK48", 2700),
            new Gun("AK49", 2800),
            new Gun("AK410", 2900),
        };
       
        for (int i = 0; i < guns.Length ; i++)
        {
            guns[i].ShowGuns();
        }

        Console.Write("Выберите оружие: ");
        int desiredGun = int.Parse(Console.ReadLine())-1;
    }
}
class Gun
{
    public string Name;
    public int Price;

    public Gun(string name, int price)
    {
       Name = name;
       Price = price;
    }
    //
    // public List<Gun> guns = new List<Gun>()
    // {
    //     new Gun("AK47", 2600),
    //     new Gun("AK48", 2700),
    //     new Gun("AK49", 2800),
    //     new Gun("AK410", 2900),
    // };

    public void ShowGuns()
    {
        Console.WriteLine(Name + " - " + "$" + Price);
    }
} 
