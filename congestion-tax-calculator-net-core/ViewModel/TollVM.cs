using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace congestion_tax_calculator.ViewModel
{
    public class TollVM
    {
        public string CityName { get; set; }
        public DateTime DateTime { get; set; }
        public int VehicleTypeId { get; set; }
    }

    public class CityVM
    {
        public string CityName { get; set; }
    }

    public class VehicleVM
    {
        public string VehicleTag { get; set; }
        public int VehicleTypeId { get; set; }
    }


    

    
}
