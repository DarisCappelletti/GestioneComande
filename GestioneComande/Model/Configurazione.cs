using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneComande.Model
{
    public class Configurazione
    {
        [Key]
        public int ID { get; set; }
        public string Intestazione { get; set; }
        public int ComandaIniziale { get; set; }
        public string Serie { get; set; }
        public string Operatore { get; set; }
    }
}
