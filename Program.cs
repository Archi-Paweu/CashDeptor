namespace GiveCash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Guy jacek = new Guy() { Cash = 50, Name = "Jacek" };
            Guy piotr = new Guy() { Cash = 100, Name = "Piotrek" };

            while (true)
            {
                jacek.WriteMyInfo();
                piotr.WriteMyInfo();

                Console.WriteLine("Podaj kwotę: ");
                string cashFlow = Console.ReadLine();
                if (cashFlow == "") return;

                if (int.TryParse(cashFlow, out int amount))
                {
                    Console.WriteLine("Pieniądze ma przekazać: ");
                    string thisGuy = Console.ReadLine();
                    if (thisGuy.ToLower() == "jacek")
                    {
                        int cashGiven = jacek.GiveCash(amount);
                        piotr.ReceiveCash(cashGiven);
                    }
                    else if (thisGuy.ToLower() == "piotr")
                    {
                        int cashGiven = piotr.GiveCash(amount);
                        jacek.ReceiveCash(cashGiven);
                    }
                    else
                    {
                        Console.WriteLine("Wpisz 'Jacek' lub 'Piotr'");
                    }

                }

                else
                {
                    Console.WriteLine("         Wpisz kwotę.");
                    Console.WriteLine("Lub wciśnij Enter, aby zakończyć.");

                }
            }
        }

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
}