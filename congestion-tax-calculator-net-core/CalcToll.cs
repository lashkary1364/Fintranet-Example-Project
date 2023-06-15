using congestion_tax_calculator.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace congestion_tax_calculator
{
    public class CalcToll
    {
        private Boolean IsTollFreeDate(DateTime date)
        {
            int year = date.Year;
            int month = date.Month;
            int day = date.Day;

            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday) return true;

            if (year == 2013)
            {
                if (month == 1 && day == 1 ||
                    month == 3 && (day == 28 || day == 29) ||
                    month == 4 && (day == 1 || day == 30) ||
                    month == 5 && (day == 1 || day == 8 || day == 9) ||
                    month == 6 && (day == 5 || day == 6 || day == 21) ||
                    month == 7 ||
                    month == 11 && day == 1 ||
                    month == 12 && (day == 24 || day == 25 || day == 26 || day == 31))
                {
                    return true;
                }
            }
            return false;
        }
       
        public int GetTollFee(TollVM toll)
        {

            TimeSpan hm = new DateTime(toll.DateTime.Year, toll.DateTime.Month, toll.DateTime.Day, toll.DateTime.Hour, toll.DateTime.Minute, 0).TimeOfDay;
            if (IsTollFreeDate(toll.DateTime) || IsTollFreeVehicle(toll.VehicleTypeId)) return 0;
            switch (toll.CityName)
            {
                case "Gothenburg":


                    if ((hm >= new TimeSpan(6, 0, 0)) && (hm <= new TimeSpan(6, 29, 0)))
                    {                                            
                        return 8;
                    }
                    else if ((hm >= new TimeSpan(6, 30, 0)) && (hm <= new TimeSpan(6, 59, 0)))
                    {
                        return 13;
                    }
                    else if ((hm >= new TimeSpan(7, 0, 0)) && (hm <= new TimeSpan(7, 59, 0)))
                    {
                        return 18;
                    }
                    else if ((hm >= new TimeSpan(8, 0, 0)) && (hm <= new TimeSpan(8, 29, 0)))
                    {
                        return 13;
                    }
                    else if ((hm >= new TimeSpan(8, 30, 0)) && (hm <= new TimeSpan(14, 59, 0)))
                    {
                        return 8;
                    }
                    else if ((hm >= new TimeSpan(15, 0, 0)) && (hm <= new TimeSpan(15, 29, 0)))
                    {
                        return 13;
                    }
                    else if ((hm >= new TimeSpan(15, 30, 0)) && (hm <= new TimeSpan(15, 59, 0)))
                    {
                        return 18;
                    }
                    else if ((hm >= new TimeSpan(17, 0, 0)) && (hm <= new TimeSpan(17, 59, 0)))
                    {
                        return 13;
                    }
                    else if ((hm >= new TimeSpan(18, 0, 0)) && (hm <= new TimeSpan(18, 29, 0)))
                    {
                        return 8;
                    }
                    else if ((hm >= new TimeSpan(18, 30, 0)) && (hm <= new TimeSpan(23, 59, 0)))
                    {
                        return 0;
                    }
                    else if ((hm >= new TimeSpan(0, 0, 0)) && (hm <= new TimeSpan(5, 59, 0)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 0;
                    }
                                      

                default:
                    return 0;

                   

            }


        }

        private bool IsTollFreeVehicle(int vehicleType)
        {

            return vehicleType.Equals(TollFreeVehicles.Motorcycle) ||
                   vehicleType.Equals(TollFreeVehicles.Busses) ||
                   vehicleType.Equals(TollFreeVehicles.Tractor) ||
                   vehicleType.Equals(TollFreeVehicles.Emergency) ||
                   vehicleType.Equals(TollFreeVehicles.Diplomat) ||
                   vehicleType.Equals(TollFreeVehicles.Foreign) ||
                   vehicleType.Equals(TollFreeVehicles.Military);
        }

        private enum TollFreeVehicles
        {
            Motorcycle = 0,
            Tractor = 1,
            Emergency = 2,
            Diplomat = 3,
            Foreign = 4,
            Military = 5,
            Busses = 6,
        }



    }



}
