using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneComande.Model
{
    public class Piatto
    {
        [Key]
        public int ID { get; set; }
        public string Tipologia { get; set; }
        public int Quantita { get; set; }
        public decimal Costo { get; set; }
    }
}
