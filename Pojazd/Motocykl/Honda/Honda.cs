using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_zaliczeniowy
{
    sealed class Honda : Motocykl
    {
        public Honda(float cenaZakupu, float marza, int rokProdukcji) : base(cenaZakupu, marza, rokProdukcji)
        {

        }
        public override string WyswietlMarke()
        {
            return "Honda";
        }
        public override string WyswietlModel()
        {
            return "Honda";
        }

        public override string WyswietlTypPojazdu()
        {
            return "Motocykl";
        }
    }
}
