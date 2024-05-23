using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();

            Osoba osoba = new Osoba("Adam", "Nowak", "81020301179");
            WaznaOsoba wazna_osoba = new WaznaOsoba("Ewa", "Kowalska", "74112302246");
            Firma firma = new Firma("Jest dobrze", "0000133456");
            DuzaFirma duza_firma = new DuzaFirma("Big Company", "0000266678");

            bank.dodajKlienta(osoba);
            bank.dodajKlienta(wazna_osoba);
            bank.dodajKlienta(firma);
            bank.dodajKlienta(duza_firma);

            Konto konto_osoba = new Konto("1134");
            Konto konto_wazna_osoba1 = new Konto("6674");
            Konto konto_wazna_osoba2 = new Konto("9921");
            Konto konto_firma1 = new Konto("9988");
            Konto konto_firma2 = new Konto("3445");
            Konto konto_duza_firma1 = new Konto("6441");
            Konto konto_duza_firma2 = new Konto("6481");
            Konto konto_duza_firma3 = new Konto("1344");

            osoba.dodajKonto(konto_osoba);
            wazna_osoba.dodajKonto(konto_wazna_osoba1);
            wazna_osoba.dodajKonto(konto_wazna_osoba2);
            firma.dodajKonto(konto_firma1);
            firma.dodajKonto(konto_firma2);
            duza_firma.dodajKonto(konto_duza_firma1);
            duza_firma.dodajKonto(konto_duza_firma2);
            duza_firma.dodajKonto(konto_duza_firma3);

            konto_osoba.wplac(3460);
            konto_wazna_osoba1.wplac(4550);
            konto_wazna_osoba2.wplac(7789);
            konto_firma1.wplac(14600);
            konto_firma2.wplac(9900);
            konto_duza_firma1.wplac(87900);
            konto_duza_firma2.wplac(65600);
            konto_duza_firma3.wplac(34300);

            double firmy = bank.saldoFirmy();
            double osoby = bank.saldoOsoby();
            double duze_firmy_i_wazne_osoby = bank.saldoDuzeFirmy_i_WazneOsoby();
            double zwykle_osoby = bank.saldoZwykleOsoby();
            Console.WriteLine("Saldo wszystkich firm: " + firmy + "\nSaldo wszystkich osób: " + osoby + "\nSaldo dużych firm i ważnych osób: " + duze_firmy_i_wazne_osoby + "\nSaldo zwykłych osób: " + zwykle_osoby);
            Console.ReadKey();
        }
    }
}
