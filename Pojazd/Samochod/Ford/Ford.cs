using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_zaliczeniowy
{
    abstract class Ford : Samochod
    {
        public Ford(float cenaZakupu, float marza, int rokProdukcji) : base(cenaZakupu, marza, rokProdukcji)
        {

        }
        public override string WyswietlMarke()
        {
            return "Ford";
        }
    }
}
