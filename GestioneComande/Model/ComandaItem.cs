using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneComande.Model
{
    public class ComandaItem
    {
        [Key]
        public int ID { get; set; }
        public int ID_Comanda { get; set; }
        public virtual Comanda comanda { get; set; }
        public int ID_Piatto { get; set; }
        public virtual Piatto piatto { get; set; }
        public int Quantita { get; set; }
    }
}
