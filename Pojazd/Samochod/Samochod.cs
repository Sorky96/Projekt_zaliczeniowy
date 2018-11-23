using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_zaliczeniowy
{
    abstract class Samochod : Pojazd
    {
        public Samochod(float cenaZakupu, float marza, int rokProdukcji) : base(cenaZakupu,marza,rokProdukcji)
        {
          
        }
    }
}
