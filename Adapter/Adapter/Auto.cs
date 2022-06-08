namespace DesignPatterns.Adapter
{
    public class Auto
    {
        public string model;
        public int age;
        public float damaged;
        public int mileage;

        public Auto(string model, int age, float damaged, int mileage)
        {
            this.model = model;
            this.age = age;
            this.damaged = damaged;
            this.mileage = mileage;
        }
    }
}
