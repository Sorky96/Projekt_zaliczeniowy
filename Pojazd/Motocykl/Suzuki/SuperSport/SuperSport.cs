using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_zaliczeniowy
{
    sealed class SuperSport : Suzuki
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
        public override string ToString()
        {
            return string.Format($"\nModel: {WyswietlModel()} Cena zakupu: {CenaZakupu}, Marza: {Marza}, Rok produkcji: {RokProdukcji}\n");
        }
    }
}
