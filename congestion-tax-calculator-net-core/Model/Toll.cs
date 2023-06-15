using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace congestion_tax_calculator
{
    [Table("Toll")]
    public class Toll
    {
        [Key]
        public int TollId { get; set; }
        
        [Required]
        public DateTime DateTime { get; set; }
        
        [Required]
        public int TaxFee { get; set; }

        public virtual Vehicle Vehicle {get;set;}
        public virtual City City { get; set; }
    }
}
