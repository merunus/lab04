namespace SecondTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Storage storage = new Storage(new Dagger(), new Club(), new Crossbow());
            storage.ShowTree(); 
        }
    }
}