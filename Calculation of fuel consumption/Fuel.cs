namespace Calculation_of_fuel_consumption
{
    public interface Fuel
    {
        public double GetFuelConsumption(double km, double AvFuelCons, double costFuel)
        {
            return (km/AvFuelCons) * costFuel;
        }
        //made by Vitya :D
    }
}
