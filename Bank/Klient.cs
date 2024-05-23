using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Klient
    {
        List<Konto> lista_Klientow = new List<Konto>();

        public List <Konto> getKonta()
        {
            foreach (Konto konto in lista_Klientow)
                Console.WriteLine(konto);
            return lista_Klientow;
        }
        public void dodajKonto(Konto konto)
        {
            lista_Klientow.Add(konto);
        }
    }
}
