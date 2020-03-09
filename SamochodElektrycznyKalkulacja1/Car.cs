using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamochodElektrycznyKalkulacja1
{
    class Car
    {
        public Car(string name, int fuelConsumptionPer100km, int powerkW, decimal literOfGasolinePrice)
        {
            Name = name;
            FuelConsumptionPer100km = fuelConsumptionPer100km;
            PowerkW = powerkW;
            LiterOfGasolinePrice = literOfGasolinePrice;
        }
        public string Name { get; }
        private int FuelConsumptionPer100km;
        private int PowerkW;
        private decimal LiterOfGasolinePrice;

        public decimal calculateFuelCost(decimal km, decimal years, decimal LiterOfGasolinePrice, decimal FuelConsumptionPer100km)
        {
            return km / 100 * LiterOfGasolinePrice * FuelConsumptionPer100km * years;
        }
    }
}
