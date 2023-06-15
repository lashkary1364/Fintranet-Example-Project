using congestion_tax_calculator.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace congestion_tax_calculator
{
    public class CalcTax
    {

        public int GetTotalTax(VehicleVM vehicle, List<DateTime> dates , CityVM city)
        {
            CalcToll toll = new();
            int totalFee = 0;
            switch (city.CityName)
            {
                case "Gothenburg":

                    for(int i = 0; i < dates.Count; i++)
                    {

                        if (i== 0)
                        {
                            totalFee = toll.GetTollFee(new TollVM(){  CityName=city.CityName,  DateTime=dates[i], VehicleTypeId=vehicle.VehicleTypeId  });
                        }
                        else
                        {
                            int nextFee = toll.GetTollFee(new TollVM() { CityName = city.CityName, DateTime = dates[i], VehicleTypeId = vehicle.VehicleTypeId });
                            long diffInMillies = dates[i].Millisecond - dates[i-1].Millisecond;
                            long minutes = diffInMillies / 1000 / 60;
                            if (minutes <= 60)
                            {
                                if (nextFee >= totalFee)
                                {
                                    totalFee = nextFee;
                                }                            

                            }
                            else
                            {
                                totalFee += nextFee;
                            }
                        }



                    }

                    if (totalFee > 60) totalFee = 60;
                    break;

                default:
                    totalFee = 0;
                    break;
               
            }         
          
            return totalFee;
        }


    }
}
