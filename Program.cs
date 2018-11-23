using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_zaliczeniowy
{
    class Program
    {
        static void Main(string[] args)
        {
            LetsMagicBegin();

            Console.Read();
            Mustang ford = new Mustang(1, 1, 2008);

        }

        static private void LetsMagicBegin()
        {

            List<Pojazd> lista = new List<Pojazd>();
          


            foreach (object o in lista)
            {
                Console.WriteLine(Convert.ToString(o));
            }
            
            GetMenuChoice();
            
        }


        static private void GetMenuChoice()
        {
            int choice;
            Console.WriteLine("Wybierz co chcesz zrobic: ");
            Console.WriteLine("---------------------------");
            Console.WriteLine("1.Wyswietl listę pojazdów");
            Console.WriteLine("2.Dodaj nowy pojazd");
            Console.WriteLine("3.Wyszukaj pojazdy");
            Console.WriteLine("4.Sprzedaj pojazd");
            Console.WriteLine("---------------------------");
            choice = Convert.ToInt32(Console.ReadLine());


            Menu(choice);
            
        }

        static private void Menu(int choice)
        {
            int rok_produkcji;
            float marza, cena;
            switch (choice)
            {
              case 1:
                    Console.Write("----Ford \n      --->Mustang \n      --->Ranger\n");
                    Console.Write("----Fiat \n      --->Panda \n      --->Multipla\n");
                    Console.Write("----Suzuki\n      --->SuperSport\n");
                    Console.Write("----Honda \n");
                    Console.Read();
              break;
                case 2:
                    Console.Write("------------------------------ \nWpisz jaki chcesz dodac pojazd\n");
                    Console.Write("1. Ford Mustang\n");
                    Console.Write("2. Ford Ranger\n");
                    Console.Write("3. Fiat Multipla\n");
                    Console.Write("4. Fiat Panda\n");
                    Console.Write("5. Suzuki SuperSport\n");
                    Console.Write("6. Honda\n");
                    choice = Convert.ToInt32(Console.Read());

                    Console.WriteLine("Wpisz cene pojazdu");
                    cena = Convert.ToSingle(Console.ReadLine());

                    Console.WriteLine("Wpisz marze pojazdu");
                    marza = Convert.ToSingle(Console.ReadLine());

                    Console.WriteLine("Wpisz rok_produkcji pojazdu");
                    rok_produkcji = Convert.ToInt32(Console.ReadLine());
                    break;
                default:

                break;

            }
        }
    }
}
