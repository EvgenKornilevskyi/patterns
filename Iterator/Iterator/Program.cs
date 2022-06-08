namespace DesignPatterns.Iterator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var staff = new StaffList();

            foreach(var employee in staff)
            {
                Console.WriteLine(employee.GetName());
            }
        }
    }
}