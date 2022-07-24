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
        public int Numero { get; set; }
        public string Serie { get; set; }
        public string Intestazione { get; set; }
        public string Operatore { get; set; }
        public string Nominativo { get; set; }
        public string Descrizione { get; set; }
        public virtual ICollection<ComandaItem> Items { get; set; }
        public decimal Pagato { get; set; }
        public decimal Totale { get; set; }
        public DateTime Data { get; set; }
    }
}

