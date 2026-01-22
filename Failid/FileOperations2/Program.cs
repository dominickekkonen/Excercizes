using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace FileOperations2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayThisFile();
            FindWord("vatafa");
            /* Kirjuta meetod mis loeb kokku mitu korda mingi sõna esineb, ning välja kuvatakse ainult kordade arv */
            WordCount("pepe");
        }

        private static void WordCount(string filter)
        {
            int countOfWord = 0;
            using (StreamReader thisFile = new StreamReader("C:\\Users\\opilane\\source\\repos\\Dominic\\Domin\\Excercizes\\Failid\\FileOperations2\\laulusõnad.txt"))
            {
                int lnr = 0;
                while (thisFile.EndOfStream == false)
                {
                    string thisLine = thisFile.ReadLine();
                    lnr++;
                    if (thisLine.Contains(filter))
                    {
                        countOfWord++;
                    }
                }
                thisFile.Close();
            }
            Console.WriteLine($"Sõna {filter} esines {countOfWord} korda");
        }

        private static void FindWord(string filter)
        {
            using (StreamReader thisFile = new StreamReader("C:\\Users\\opilane\\source\\repos\\Dominic\\Domin\\Excercizes\\Failid\\FileOperations2\\laulusõnad.txt"))
            {
                int lnr = 0;
                while (thisFile.EndOfStream == false)
                {
                    string thisLine = thisFile.ReadLine();
                    lnr++;
                    if (thisLine.Contains(filter))
                    {
                        Console.WriteLine("Sõna "+filter+" leitud realt #"+lnr+"");
                    }
                }
                thisFile.Close();
            }
        }

        private static void DisplayThisFile()
        {
            string rida = "";
            using (StreamReader thisFile = new StreamReader("C:\\Users\\opilane\\source\\repos\\Dominic\\Domin\\Excercizes\\Failid\\FileOperations2\\laulusõnad.txt"))
            {
                int currentRow = 0;
                while (thisFile.EndOfStream == false)
                {
                    currentRow++;
                    rida = thisFile.ReadLine();
                    int pikkus = rida.Length;
                    Console.WriteLine($"#{currentRow} pikkus: {pikkus} tekst: {rida}");
                }
                thisFile.Close();
            }
            
        }
    }
}
