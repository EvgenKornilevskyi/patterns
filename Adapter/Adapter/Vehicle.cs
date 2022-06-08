namespace DesignPatterns.Adapter
{
    public class Vehicle
    {
        private string model;
        private int age;
        private float damaged;
        private int mileage;

        public Vehicle(string model, int age, float damaged, int mileage)
        {
            this.model = model;
            this.age = age;
            this.damaged = damaged;
            this.mileage = mileage;
        }

        public int getAge()
        {
            return age;
        }
        public string getModel()
        {
            return model;
        }
        public float getDamage()
        {
            return damaged;
        }
        public int getMileage()
        {
            return mileage;
        }
    }
}
