using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Bank
    {
        List<Klient> lista_Klientow_Banku = new List<Klient>();

        public void getKlienci()
        {
            foreach (Klient klient in lista_Klientow_Banku)
                Console.WriteLine(klient);
        }
        public void dodajKlienta(Klient klient)
        {
            lista_Klientow_Banku.Add(klient);
        }
        public double saldoFirmy()
        {
            double suma = 0;
            foreach (Klient klient in lista_Klientow_Banku)
            {
                if (klient is Firma)
                {
                    klient.getKonta().ForEach(konto => suma += konto.get_saldo());
                }
            }
            return suma;
        }
        public double saldoOsoby()
        {
            double suma = 0;
            foreach (Klient klient in lista_Klientow_Banku)
            {
                if (klient is Osoba)
                {
                    klient.getKonta().ForEach(konto => suma += konto.get_saldo());
                }
            }
            return suma;
        }
        public double saldoDuzeFirmy_i_WazneOsoby()
        {
            double suma = 0;
            foreach (Klient klient in lista_Klientow_Banku)
            {
                if (klient is WaznaOsoba || klient is DuzaFirma)
                {
                    klient.getKonta().ForEach(konto => suma += konto.get_saldo());
                }
        }
        return suma;
    }
        public double saldoZwykleOsoby()
        {
            double suma = 0;
            foreach (Klient klient in lista_Klientow_Banku)
            {
                if (klient is Osoba && !(klient is WaznaOsoba))
                {
                    klient.getKonta().ForEach(konto => suma += konto.get_saldo());
                }
            }
            return suma;
        }
    }
}
