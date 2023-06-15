using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace congestion_tax_calculator
{
    [Table("Vehicle")]
    [Index(nameof(VehicleTag))]
    public class Vehicle    { 
        [Key]
        public int VehicleId { get; set;  }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        
        [Required]
        [MaxLength(10)]        
        public string VehicleTag { get; set; }
        public virtual VehicleType VehicleType { get; set; }
    }
}