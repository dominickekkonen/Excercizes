using System.Dynamic;

namespace Meethod_excercizes_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float arv1 = 0;
            float arv2 = 0;
            string tehtetüüp = "";
            string uusTehe = "jah";
            while (uusTehe == "jah")
            {
                double tulemus = 0;
                GetUserData(arv1, arv2, tehtetüüp);
                switch (tehtetüüp)
                {
                    case "+":
                        tulemus = Liida(arv1, arv2);
                        break;
                    case "-":
                        tulemus = Lahuta(arv1, arv2);
                        break;
                    case "*":
                        tulemus = Korruta(arv1, arv2);
                        break;
                    case "/":
                        tulemus = Jaga(arv1, arv2);
                        break;
                    default:
                        Console.WriteLine("Ei tunne tehtetüüpi");
                        break;
                }
            }
        }

        private static double Liida(float arv1, float arv2)
        {
            return arv1 + arv2;
        }
        private static double Lahuta(float arv1, float arv2)
        {
            return arv1 - arv2;
        }
        private static double Korruta(float arv1, float arv2)
        {
            return arv1 * arv2;
        }
        private static double Jaga(float arv1, float arv2)
        {
            return arv1 / arv2;
        }

        private static void GetUserData(float arv1, float arv2, string tehtetüüp)
        {
            while (arv1  == 0)
            {
                Console.WriteLine("palun sisesta esimine arv");
                arv1 = float.Parse(Console.ReadLine());
            }
            while (arv2 == 0)
            {
                Console.WriteLine("palun sisesta teine arv");
                arv2 = float.Parse(Console.ReadLine());
            }
            while (tehtetüüp == "")
            {
                Console.WriteLine("Palun sisesta tehtetüüp");
                tehtetüüp = Console.ReadLine();
            }
        }
    }
}
