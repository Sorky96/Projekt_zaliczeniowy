using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_zaliczeniowy
{
    abstract class Samochod : Pojazd
    {
        public override string WyswietlModel()
        {
            return "Pojazd";
        }
    }

    abstract class Ford : Samochod
    {
        public override string WyswietlMarke()
        {
            return "Ford";
        }
    }

    abstract class Fiat : Samochod
    {
        public override string WyswietlMarke()
        {
            return "Fiat";
        }
    }

    sealed class Mustang : Ford
    {
        public override string WyswietlModel()
        {
            return "Mustang";
        }
    }

    sealed class Ranger : Ford
    {
        public override string WyswietlModel()
        {
            return "Ranger";
        }
    }

    sealed class Multipla : Fiat
    {
        public override string WyswietlModel()
        {
            return "Multipla";
        }
    }

    sealed class Panda : Fiat
    {
        public override string WyswietlModel()
        {
            return "Panda";
        }
    }
}
