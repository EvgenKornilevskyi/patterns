namespace DesignPatterns.Adapter
{
    public class TruckCalculator : VehicleCalculator
    {
        private Vehicle vehicle;
        public int calculatePrice()
        {
            return vehicle.getAge() * 100 + vehicle.getMileage() * 100 + (int)(vehicle.getDamage() * 100);
        }
        public void setVehicle(Vehicle vehicle)
        {
            this.vehicle = vehicle;
        }
    }
}
