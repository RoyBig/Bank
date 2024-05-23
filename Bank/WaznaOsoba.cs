using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class WaznaOsoba : Osoba
    {
        public WaznaOsoba(string imie, string nazwisko, string PESEL) : base(imie, nazwisko, PESEL)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.PESEL = PESEL;
        }
    }
}
