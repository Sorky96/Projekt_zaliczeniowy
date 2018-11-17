using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_zaliczeniowy
{
    abstract class Motocykl : Pojazd
    {
        public Motocykl(float cenaZakupu, float marza, int rokProdukcji) : base(cenaZakupu, marza, rokProdukcji)
        {

        }
        
    }

    abstract class Suzuki : Motocykl
    {
        public Suzuki(float cenaZakupu, float marza, int rokProdukcji) : base(cenaZakupu, marza, rokProdukcji)
        {

        }
        public override string WyswietlMarke()
        {
            return "Su-zuuu-kiii";
        }
    }

    abstract class Honda : Motocykl
    {
        public Honda(float cenaZakupu, float marza, int rokProdukcji) : base(cenaZakupu, marza, rokProdukcji)
        {

        }
        public override string WyswietlMarke()
        {
            return "Honda";
        }

    }

    sealed  class SuperSport : Suzuki
    {
        public SuperSport(float cenaZakupu, float marza, int rokProdukcji) : base(cenaZakupu, marza, rokProdukcji)
        {

        }
        public override string WyswietlTypPojazdu()
        {
            return "Motocykl";
        }
        public override string WyswietlModel()
        {
            return "SuperSport";
        }
    }

}
