namespace ThirdTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Truck truck = new Truck();
            Watercraft watercraft = new Watercraft();
            Helicopter helicopter = new Airplane();
            truck.ShowPoperties();
            watercraft.ShowPoperties();
            helicopter.ShowPoperties();   
        }
    }
}