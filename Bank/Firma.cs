using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Firma : Klient
    {
        protected string nazwa, KRS;
        public Firma(string nazwa, string KRS)
        {
            this.nazwa = nazwa;
            this.KRS = KRS;
        }
    }
}
