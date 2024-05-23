using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Osoba : Klient
    {
        protected string imie, nazwisko, PESEL;
        public Osoba(string imie, string nazwisko, string PESEL)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.PESEL = PESEL;
        }
        public override string ToString()
        {
            string data = imie + " " + nazwisko + " " + PESEL;
            return data;
        }
    }
}
