using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class DuzaFirma : Firma
    {
        public DuzaFirma(string nazwa, string KRS) : base(nazwa, KRS)
        {
            this.nazwa = nazwa;
            this.KRS = KRS;
        }
    }
}
