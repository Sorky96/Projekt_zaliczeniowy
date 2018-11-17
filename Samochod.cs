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

    abstract class Fiat : Samochod
    {
        public Fiat(float cenaZakupu, float marza, int rokProdukcji) : base(cenaZakupu, marza, rokProdukcji)
        {

        }
        public override string WyswietlMarke()
        {
            return "Fiat";
        }
    }

    sealed class Mustang : Ford
    {
        public Mustang(float cenaZakupu, float marza, int rokProdukcji) : base(cenaZakupu, marza, rokProdukcji)
        {

        }
        public override string WyswietlTypPojazdu()
        {
            return "Samochod";
        }
        public override string WyswietlModel()
        {
            return "Mustang";
        }
    }

    sealed class Ranger : Ford
    {
        public Ranger(float cenaZakupu, float marza, int rokProdukcji) : base(cenaZakupu, marza, rokProdukcji)
        {

        }
        public override string WyswietlTypPojazdu()
        {
            return "Samochod";
        }
        public override string WyswietlModel()
        {
            return "Ranger";
        }
    }

    sealed class Multipla : Fiat
    {
        public Multipla(float cenaZakupu, float marza, int rokProdukcji) : base(cenaZakupu, marza, rokProdukcji)
        {

        }
        public override string WyswietlTypPojazdu()
        {
            return "Samochod";
        }
        public override string WyswietlModel()
        {
            return "Multipla";
        }
    }

    sealed class Panda : Fiat
    {
        public Panda(float cenaZakupu, float marza, int rokProdukcji) : base(cenaZakupu, marza, rokProdukcji)
        {

        }
        public override string WyswietlTypPojazdu()
        {
            return "Samochdod";
        }
        public override string WyswietlModel()
        {
            return "Panda";
        }
    }
}
