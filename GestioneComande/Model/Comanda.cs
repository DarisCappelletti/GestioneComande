using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneComande.Model
{
    public class Comanda
    {
        [Key]
        public int ID { get; set; }
        public string Descrizione { get; set; }
        public decimal Totale { get; set; }
        public DateTime Data { get; set; }
    }
}

