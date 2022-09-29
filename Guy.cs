namespace GiveCash
{
    class Guy
    {
        public string Name;
        public int Cash;


        public void WriteMyInfo()
        {
            Console.WriteLine(Name + " ma " + Cash + " zł.");
        }
        public int GiveCash(int amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Kwota " + amount + " nie jest poprawną kwotą!");
                return 0;
            }
            if (amount > Cash)
            {
                Console.WriteLine("Nie ma wystarczających środków aby dać ci " + amount);
                return 0;
            }
            Cash = Cash - amount;
            return amount;
        }
        public void ReceiveCash(int amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Nie przyjmę od Ciebie długu  wysokości " + amount);

            }
            else Cash = Cash + amount;
        }


    }
}
