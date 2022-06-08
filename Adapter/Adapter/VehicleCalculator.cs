namespace DesignPatterns.Adapter
{
    public interface VehicleCalculator
    {
        public void setVehicle(Vehicle vehicle);
        public int calculatePrice();
    }
}
