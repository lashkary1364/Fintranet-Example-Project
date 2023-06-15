using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace congestion_tax_calculator
{
    [Table("VehicleType")]
    public class VehicleType
    {
        [Key]
        public int VehicleTypeId { get; set; }
        [Required]
        [StringLength(20)]
        public string VehicleTypeName { get; set; }
    }
}
