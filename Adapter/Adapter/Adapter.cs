namespace DesignPatterns.Adapter
{
    public class Adapter : VehicleCalculator
    {
        private readonly UkrainianCustoms ukrainianCustoms;

        public Adapter(UkrainianCustoms ukrainianCustoms)
        {
            this.ukrainianCustoms = ukrainianCustoms;
        }
        public int calculatePrice()
        {
            var auto = ukrainianCustoms.GetAuto();
            var vehicle = new Vehicle(auto.model, auto.age, auto.damaged, auto.mileage);
            return ukrainianCustoms.vehiclePrice(auto);
        }

        public void setVehicle(Vehicle vehicle)
        {
            throw new NotImplementedException();
        }
    }
}
