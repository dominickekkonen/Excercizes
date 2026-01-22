



namespace Meetodi_Kontrolltöö_16._01._2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1. tervitus (meetodiga)  \/
             * 2. järjend muutujat kus on sees viis arvu, ise mõtled millised.
             * float - muutujad kuhu omistatakse järjendi arvutuse tulemus 
             * järjend tuleb kokku arvutada meetodiga 
             * 3. küsitakse kasutajalt nime  \/ 
             * on muutuja kuhu (meetodi abil) pannakse nimes olevate tähtede arv 
             * see muutuja kuvatakse kasutajale välja 
             * 4. küsib kasutajalt kui raske ta on 
             * on muutuja kuhu (meetodi abil) pannakse sõnum 
             * see muutuja kuvatakse kasutajale välja 
             */

            Tervitus();
            Arvutamine();
            Kasutajanimi();
            KasutajaRaskus();
            
        }

        private static List <string> Arvutamine()
        {
            var arvud = new List<string>();

            foreach (var arv in arvud)
            {
                Console.WriteLine(arv);

            }
            return arvud;
        }

        private static void KasutajaRaskus()
        {
            double kasutajaRaskus = 0;
            Console.WriteLine("Palun sisesta oma raskus: ");
            kasutajaRaskus = double.Parse(Console.ReadLine()); 
            if (kasutajaRaskus >= 20 &&  kasutajaRaskus <= 60)
            {
                Console.WriteLine("Oled pisikene");
            }
            else if (kasutajaRaskus >= 61 && kasutajaRaskus <= 80)
            {
                Console.WriteLine("normaalne");
            }
            else if (kasutajaRaskus >= 81 && kasutajaRaskus <= 120)
            {
                Console.WriteLine("oled planeet");
            }
            else
            {
                Console.WriteLine("Ei tunne sellist raskusi");
            }
            
        }

        private static void Kasutajanimi()
        {
            string kasutajanimi = "";
            Console.WriteLine("Palun sisesta oma kasutajanimi: ");
            kasutajanimi = Console.ReadLine();
            Console.WriteLine(kasutajanimi.Length);
        }

        private static void Tervitus()
            {
                Console.WriteLine("Tere, Kasutaja!");
        }

    }
}
