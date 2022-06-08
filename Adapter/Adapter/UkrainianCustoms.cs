namespace DesignPatterns.Adapter
{
    public class UkrainianCustoms : Customs
    {
        private Auto auto;
        public UkrainianCustoms(Auto auto)
        {
            this.auto = auto;
        }
        public int vehiclePrice(Auto auto)
        {
            return auto.mileage * 10 + auto.age * 10 + (int)(auto.damaged * 10);    
        }
        public Auto GetAuto()
        {
            return auto;
        }
    }
}
