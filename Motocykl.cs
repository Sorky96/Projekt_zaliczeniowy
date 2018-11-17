using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_zaliczeniowy
{
    abstract class Motocykl : Pojazd
    {
        public override string WyswietlTypPojazdu()
        {
            return "Motocykl";
        }
    }

    abstract class Suzuki : Motocykl
    {
        public override string WyswietlMarke()
        {
            return "Su-zuuu-kiii";
        }
    }

    abstract class Honda : Motocykl
    {
        public override string WyswietlMarke()
        {
            return "Honda";
        }

    }

    sealed  class SuperSport : Suzuki
    {
        public override string WyswietlModel()
        {
            return "SuperSport";
        }
    }

}
