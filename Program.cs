using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_zaliczeniowy
{
    class Program
    {
        static List<Pojazd> lista = new List<Pojazd>();

        static void Main(string[] args)
        {
            
            LetsMagicBegin();
            
            Console.Read();
        }

        static private void LetsMagicBegin()
        {
            GetMenuChoice();

        }

        /// <summary>
        /// Menu provided to user at the star of the program, have 4 options to choose 
        /// </summary>

        static private void GetMenuChoice()
        {

            Console.WriteLine("Wybierz co chcesz zrobic: ");
            Console.WriteLine("---------------------------");
            Console.WriteLine("1.Wyswietl listę pojazdów");
            Console.WriteLine("2.Dodaj nowy pojazd");
            Console.WriteLine("3.Wyszukaj pojazdy");
            Console.WriteLine("4.Usun pojazdy");
            Console.WriteLine("---------------------------");
            var choice = Console.ReadLine();

            Console.Clear();

            Menu(choice);
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


                    break;
                case 2:
                    lista.Add(new Ranger(cena, marza, rok_produkcji));


                    break;
                case 3:
                    lista.Add(new Multipla(cena, marza, rok_produkcji));

                    break;
                case 4:
                    lista.Add(new Panda(cena, marza, rok_produkcji));

                    break;
                case 5:
                    lista.Add(new SuperSport(cena, marza, rok_produkcji));

                    break;

                case 6:
                    lista.Add(new Honda(cena, marza, rok_produkcji));

                    break;
                default:

                    break;

            }

            Console.Clear();
            GetMenuChoice();
        }


        /// <summary>
        /// When user provide his choice he will be here. 
        /// </summary>
        /// <param name="choice"></param>

        static private void Menu(string choice)
        {
            int rok_produkcji;
            float marza, cena;


            


            switch (choice)
            {
                case "1":
                    Console.Write("----Ford \n      --->Mustang \n      --->Ranger\n");
                    Console.Write("----Fiat \n      --->Panda \n      --->Multipla\n");
                    Console.Write("----Suzuki\n      --->SuperSport\n");
                    Console.Write("----Honda \n");
                    Console.Read();
                    break;

                case "2":
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
                    int second_level_choice = Convert.ToInt16(Console.ReadLine());

                    Add_car_menu(second_level_choice, cena, marza, rok_produkcji);

                    break;

                case "3":
                   
                    Console.Write("------------------------------ \nWyszukaj po: \n");
                    Console.Write("1. Rocznik \n");
                    Console.Write("2. Cena \n");
                    var new_choice = Console.ReadLine();

                    SearchFor(new_choice);

                    Console.Read();
                    break;

                case "4":

                    Console.Write("------------------------------ \n Usun po: \n");
                    Console.Write("1. Rocznik \n");
                    Console.Write("2. Cena \n");
                    var delete_choice = Console.ReadLine();

                    DeleteFromList(delete_choice);

                    Console.Read();
                    break;

                default:
                    
                    break;


            }
            GetMenuChoice();
            Console.Clear();
        }
        /// <summary>
        /// Method that serach for specific cars that they are in the range of query. You can search for price or year
        /// </summary>
        /// <param name="choice"> provided by user</param>
        static void SearchFor(string choice)
        {
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Podaj przedzial lat od \n");
                    int starting_year = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Podaj przedzial lat do \n");
                    int final_year = Convert.ToInt32(Console.ReadLine());

                    List<Pojazd> year_result = lista.FindAll(delegate (Pojazd item)
                    {
                        return item.RokProdukcji >= starting_year && item.RokProdukcji <= final_year;
                        
                    });
                    if (year_result.Count != 0)
                    {
                        foreach (Pojazd p in year_result)
                        {
                            Console.WriteLine(Convert.ToString(p));
                        }
                    }
                    else
                    {
                        Console.Write("Lista jest pusta\n");
                    }
                    
                    Console.Read();
                    break;

                case "2":
                    Console.WriteLine("Podaj przedzial cenowy od \n");
                    int starting_price = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Podaj przedzial cenowy do \n");
                    int final_price = Convert.ToInt32(Console.ReadLine());
                    


                    List<Pojazd> price_result = lista.FindAll(delegate (Pojazd item)
                    {
                        return item.CenaZakupu >= starting_price && item.CenaZakupu <= final_price;
                    });
                    if (price_result.Count != 0)
                    {
                        foreach (Pojazd p in price_result)
                        {
                            Console.WriteLine(Convert.ToString(p));
                        }
                    }
                    else
                    {
                        Console.Write("Lista jest pusta\n");
                    }

                        Console.Read();
                    break;
            }
            GetMenuChoice();
            Console.Clear();
        }

        static void DeleteFromList(string choice)
        {
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Podaj przedzial lat od \n");
                    int starting_year = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Podaj przedzial lat do \n");
                    int final_year = Convert.ToInt32(Console.ReadLine());

                    List<Pojazd> year_result = lista.FindAll(delegate (Pojazd item)
                    {
                        lista.RemoveAll(x => x.RokProdukcji  >= starting_year && x.RokProdukcji <= final_year);
                        return item.RokProdukcji >= starting_year && item.RokProdukcji <= final_year;

                    });
                   
                    if (year_result.Count == 0)
                    {
                        Console.Write("Lista jest pusta\n");
                    }
                    Console.WriteLine("Usunieto podane pozycje");
                    Console.Read();
                    break;

                case "2":
                    Console.WriteLine("Podaj przedzial cenowy od \n");
                    int starting_price = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Podaj przedzial cenowy do \n");
                    int final_price = Convert.ToInt32(Console.ReadLine());
                    lista.Add(new Mustang(1000, 2000, 2019));


                    List<Pojazd> price_result = lista.FindAll(delegate (Pojazd item)
                    {
                        lista.RemoveAll(x => x.CenaZakupu >= starting_price && x.CenaZakupu <= final_price);
                        return item.CenaZakupu >= starting_price && item.CenaZakupu <= final_price;
                    });
                   
                    if (price_result.Count == 0)
                    {
                        Console.Write("Lista jest pusta\n");
                    }
                    Console.WriteLine("Usunieto wybrane pozycje");
                    Console.Read();
                    break;
            }
            GetMenuChoice();
            Console.Clear();
        }
    }
}

