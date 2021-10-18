namespace classestrial
{
    public class Car : Vehicle
    {
        private double FuelCapacity;
        public Car(double fuelCapacity, double mileage) : base(mileage)
        {
            FuelCapacity = fuelCapacity;
        }

        public double GetFuelCapacity()
        {
            return FuelCapacity;
        }
    }
}
