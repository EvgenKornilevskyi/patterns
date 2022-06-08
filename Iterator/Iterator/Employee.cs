namespace DesignPatterns.Iterator
{
    public class Employee
    {
        private readonly string _name;

        public Employee(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }
    }
}
