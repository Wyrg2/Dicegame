using System.ComponentModel.Design;

namespace Dicegame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int summa = 0;
            int dealersumma = 0;
            string stopp = "start";
            string svar;
            Console.WriteLine("Välkommen till Dicegame. Vill du spela?");
            string jaellernej = (Console.ReadLine());
            if (jaellernej == "ja" || jaellernej == "Ja")
            {
                while (stopp == "start")
                {
                    Random rand = new Random();
                    int randomnumber = rand.Next(1, 7);
                    Random dealerrrand = new Random();
                    int dealerrandomnumber = dealerrrand.Next(1, 7);
                    summa += randomnumber;
                    dealersumma += dealerrandomnumber;
                    Console.WriteLine("Du har slagit " + randomnumber + ". Du har totalt " + summa);
                    Console.WriteLine("Dealern har slagit " + dealerrandomnumber + ". Dealern har totalt " + dealersumma);
                    if (dealersumma >= 22 || summa >= 22)
                    {
                        stopp = "stopp";
                    }else
                    {
                        Console.WriteLine("Vill du kasta igen?");
                        svar = (Console.ReadLine());
                        if (svar == "Nej" || svar == "nej")
                        {
                            stopp = "stopp";
                        }
                    }
                }
                if (dealersumma >= 22 && summa <= 21)
                {
                    Console.WriteLine("Dealern fick över 21. Du vann. Grattis");
                }else if (summa >= 22 && dealersumma <= 21)
                {
                    Console.WriteLine("Du fick över 21. Du förlorade. :(");
                }else if (summa == dealersumma)
                {
                    Console.WriteLine("Ni fick lika mycket. Du förlorade :(");
                }else if (dealersumma <20 && summa <= 20)
                {
                    if (dealersumma >= summa)
                    {
                        Console.WriteLine("Dealern fick " + dealersumma + " och du fick " + summa + ". Du förlorade :(");
                    }
                    else
                    {
                        Console.WriteLine("Dealern fick " + dealersumma + " och du fick " + summa + ". Du vann. Grattis");
                    }
                }
            }
            else if (jaellernej == "nej" || jaellernej == "Nej")
            {
                Console.WriteLine("ok. ha en bra dag :)");
            }
            else
            {
                Console.WriteLine("Förstår inte.");
            }
        }
    }
}
