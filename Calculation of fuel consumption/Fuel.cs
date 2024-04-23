namespace Calculation_of_fuel_consumption
{
    public static class Fuel // interfeice
    {
        public static double GetFuelConsumption(double km, double AvFuelCons, double costFuel)
        {
            //
            return (km/100*AvFuelCons) * costFuel;
        }
        //made by Vitya :D
    }
}
