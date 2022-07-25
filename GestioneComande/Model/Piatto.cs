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
        public string Nome { get; set; }
        public string Tipologia { get; set; }
        public int Quantita { get; set; }
        public decimal Costo { get; set; }
        public virtual ICollection<ComandaItem> Items { get; set; }
        public bool Attivo { get; set; }
        public bool Eliminato { get; set; }
    }
}
