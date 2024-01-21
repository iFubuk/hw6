namespace ConsoleApp5

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Yacht yacht = new Yacht(20, 5,"A1", 156.3, null, 3000);
            Console.WriteLine(yacht.ToString());
            Ship ship = new Ship(30, -1, "B2", 534.6, 30000, 50);
            Console.WriteLine(ship.ToString());
            Barge barge = new Barge(10, 10, null, 333.6, 200, "SSS");
            Console.WriteLine(barge.ToString());
            yacht.Swim();
            ship.Swim();
            barge.Swim();
        }
    }
}
