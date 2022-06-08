namespace DesignPatterns.Iterator
{
    public class StaffList
    {
        private readonly List<Employee> _employees = new List<Employee> 
        { 
            new Employee("John"), 
            new Employee("Bob"),
            new Employee("Anatoliy")
        };
        public IEnumerator<Employee> GetEnumerator() => new StaffListIterator(_employees);
    }
}
