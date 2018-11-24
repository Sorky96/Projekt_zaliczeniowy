﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_zaliczeniowy
{
    class Menu_class
    {
        static private void GetMenuChoice()
        {
            int choice = 0;
            Console.WriteLine("Wybierz co chcesz zrobic: ");
            Console.WriteLine("---------------------------");
            Console.WriteLine("1.Wyswietl listę pojazdów");
            Console.WriteLine("2.Dodaj nowy pojazd");
            Console.WriteLine("3.Wyszukaj pojazdy");
            Console.WriteLine("4.Sprzedaj pojazd");
            Console.WriteLine("---------------------------");
            choice = Convert.ToInt16(Console.ReadLine());


            Menu(choice);

        }
        /// <summary>
        /// When user provide his choice he will be here. 
        /// </summary>
        /// <param name="choice"></param>
        static private void Menu(int choice)
        {
            int rok_produkcji, second_level_choice;
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
                    Console.WriteLine("Wpisz cene pojazdu");
                    cena = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat); // With cultureinfo user can use "." as seperator or "," base of windows option

                    Console.WriteLine("Wpisz marze pojazdu");
                    marza = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);

                    Console.WriteLine("Wpisz rok_produkcji pojazdu");
                    rok_produkcji = Convert.ToInt32(Console.ReadLine());

                    Console.Write("------------------------------ \nWpisz jaki chcesz dodac pojazd\n");
                    Console.Write("1. Ford Mustang\n");
                    Console.Write("2. Ford Ranger\n");
                    Console.Write("3. Fiat Multipla\n");
                    Console.Write("4. Fiat Panda\n");
                    Console.Write("5. Suzuki SuperSport\n");
                    Console.Write("6. Honda\n");
                    second_level_choice = Convert.ToInt32(Console.Read());
                    Add_car_menu(second_level_choice, cena, marza, rok_produkcji);
                    break;
                default:
                    GetMenuChoice();
                    break;

            }

        }


        /// <summary>
        /// Adds car to list of all cars. 
        /// </summary>
        /// <param name="choice"> param from Menu function, second_level_choice</param>
        /// <param name="cena"></param>
        /// <param name="marza"</param>
        /// <param name="rok_produkcji"></param>

        static private void Add_car_menu(int choice, float cena, float marza, int rok_produkcji)
        {
            switch (choice)
            {
                case 1:
                    lista.Add(new Mustang(cena, marza, rok_produkcji));

                    GetMenuChoice();
                    break;
                case 2:
                    lista.Add(new Ranger(cena, marza, rok_produkcji));
                    // GetMenuChoice();
                    LetsMagicBegin();
                    break;
                case 3:
                    lista.Add(new Multipla(cena, marza, rok_produkcji));
                    GetMenuChoice();
                    break;
                case 4:
                    lista.Add(new Panda(cena, marza, rok_produkcji));
                    GetMenuChoice();
                    break;
                case 5:
                    lista.Add(new SuperSport(cena, marza, rok_produkcji));
                    GetMenuChoice();
                    break;

                case 6:
                    lista.Add(new Honda(cena, marza, rok_produkcji));
                    GetMenuChoice();
                    break;
                default:
                    GetMenuChoice();
                    break;

            }
        }
    }
}