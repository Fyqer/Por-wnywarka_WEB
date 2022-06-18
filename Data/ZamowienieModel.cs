using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektSklepp.Data
{
    public class ZamowienieModel
    {
        public int ID { get; set; }
        public int KlientID { get; set; }
        public int Koszt_zamowienia { get; set; }
        public string Adres_dostawy { get; set; }
        public string Sklep { get; set; }
        public string Nazwisko_klienta { get; set; }
        public string Imie_klienta { get; set; }
        public string Status { get; set; }
        public string Zakupione_produkty { get; set; }
        public string Miasto { get; set; }
        public DateTimeOffset Data { get; set; }
        public string Kurier { get; set; }
    }
}
