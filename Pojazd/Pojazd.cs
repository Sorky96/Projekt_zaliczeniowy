using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_zaliczeniowy
{
    abstract class Pojazd
    {

        private float fCenaZakupu = 0.0f;
        private float fMarza = 0.0f;
        private int iRokProdukcji = 0;

        public Pojazd(float cenaZakupu, float marza, int rokProdukcji)
        {
            fMarza = marza;
            fCenaZakupu = cenaZakupu;
            iRokProdukcji = rokProdukcji;
        }

        public float Marza
        {
            get { return fMarza; }
        }
        
        public float CenaZakupu
        {
            get { return fCenaZakupu; }
        }

        public int RokProdukcji
        {
            get { return iRokProdukcji; }
        }

        

       
        public void WyswietlRok()
        {

        }

        public float CenaKoncowa()
        {
            return fCenaZakupu + (fCenaZakupu * fMarza);
        }

        public abstract string WyswietlMarke();

        public abstract string WyswietlModel();

        public abstract string WyswietlTypPojazdu();
       


       
    }
}
