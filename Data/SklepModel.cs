using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektSklepp.Data
{
    public class SklepModel
    {
        public int Id { get; set; } = 0;
        public string Nazwa { get; set; } = "";
        public string Miasto { get; set; } = "";
        public string  Kod_sklepu { get; set; } = "";

    }
}
