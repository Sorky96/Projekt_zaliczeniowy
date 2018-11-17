using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_zaliczeniowy
{
    abstract class Pojazd
    {

        private float fCenaZakupu;
        private float fMarza;
        private int iRokProdukcji;


        
        public float Marza
        {
            get;
        }

        public float CenaZakupu
        {
            get;
        }

        public int RokProdukcji
        {
            get;
        }

        public void WyswietlRok()
        {

        }

        public float CenaKoncowa()
        {
            return fCenaZakupu + fMarza;
        }

        public virtual string WyswietlMarke()
        {
            return null;
        }

        public virtual string WyswietlModel()
        {
            return null;
        }

        public virtual string WyswietlTypPojazdu()
        {
            return null;
        }


       
    }
}
