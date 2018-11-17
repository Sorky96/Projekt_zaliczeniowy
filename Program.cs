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
                    Console.Write("------------------------------ \nWpisz jaki chcesz dodac pojazd");
                    break;
                default:

                break;

            }
        }
    }
}
