namespace SecondTask
{
    public abstract class ColdWeapon
    {
        protected int condition;
        protected int price;
        protected int damage;

        public virtual int CalculateDamage()
        {
            return damage;
        }

        public virtual void Repair()
        {
            condition += 20;
        }

        public virtual int Sell()
        {
            return price;
        }

        public virtual void ShowMethods()
        {
            Console.WriteLine(GetType().Name);
            foreach (var method in GetType().GetMethods())
            {
                Console.WriteLine(method.Name);
            }
            Console.WriteLine();
        }
    }
}
