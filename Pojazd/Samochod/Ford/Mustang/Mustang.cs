﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_zaliczeniowy
{
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
        public override string ToString()
        {
            return string.Format($"Model: {WyswietlModel()} Cena zakupu: {CenaZakupu}, Marza: {Marza}, Rok produkcji: {RokProdukcji}\n");
        }
    }
}
