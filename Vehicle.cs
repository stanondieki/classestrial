namespace classestrial
{
    public class Vehicle
    {
        public string Make;
        public string Model;
        public string EngineNo;
        public double Mileage;

        public Vehicle(double mileage)
        {
            Mileage = mileage;
        }

        public double GetRemainingDistance()
        {
            // This is a fake calculation
            return Mileage * 134;
        }
    }
}
