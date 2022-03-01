using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektSklepp.Data
{
    public class ProduktModel
    {
        [Key]
        public int ID { get; set; }
        public double  cena_produktu { get; set; }
        public string nazwa_produktu { get; set; }
        public int sklepID { get; set; }
        public string firma_produktu{ get; set; }
        public int Ilosc { get; set; }
        public string Miasto { get; set; }
    }
}
