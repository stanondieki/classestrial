namespace classestrial
{
    public class Bus : Vehicle
    {
        private int Capacity;
        public Bus(int capacity, double mileage) : base(mileage)
        {
            Capacity = capacity;
        }

        public double GetCapacity()
        {
            // This is a fake calculation
            return Capacity * (Mileage/10000);
        }
    }
}
