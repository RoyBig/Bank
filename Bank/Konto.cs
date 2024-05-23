using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Konto
    {
        private string nr;
        private double saldo;
        public Konto(string nr)
        {
            this.nr = nr;
            saldo = 0;
        }
        public double get_saldo()
        {
            Console.WriteLine("Twoj stan konta: " + saldo + " zl");
            return saldo;
        }
        public string get_Nr()
        {
            return nr;
        }
        public void wplac(double kwota)
        {
            saldo += kwota;
            Console.WriteLine("Wplacono " + kwota + " zl");
        }
        public void wyplac(double kwota)
        {
            if (saldo - kwota < 0)
                Console.WriteLine("Brak wystarczajacych srodkow na koncie");
            else
            {
                saldo -= kwota;
                Console.WriteLine("Wyplacono " + kwota + " zl.");
                Console.WriteLine("Pozostało " + saldo + " zł.");
            }
        }
        public override string ToString()
        {
            string account = nr + ". " + saldo + " zl";
            return account;
        }


    }
}
