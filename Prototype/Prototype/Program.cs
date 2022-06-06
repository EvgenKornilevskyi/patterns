namespace DesignPatterns.Builder
{
    public class Identity
    {
        public int age;
        public string? name;
        public Id id;
        public Identity ShallowCopy()
        {
            return (Identity) this.MemberwiseClone();
        }
        public Identity DeepCopy()
        {
            Identity clone = (Identity) this.MemberwiseClone();
            clone.id = new Id(id.idNumber);
            return clone;  
        }
    }
    public class Id
    {
        public int idNumber;
        public Id(int idNumber)
        {
            this.idNumber = idNumber;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Identity p1 = new Identity();
            p1.age = 42;
            p1.name = "Jack Daniels";
            p1.id = new Id(666);

            // Perform a shallow copy of p1 and assign it to p2.
            Identity p2 = p1.ShallowCopy();
            // Make a deep copy of p1 and assign it to p3.
            Identity p3 = p1.DeepCopy();

            // Display values of p1, p2 and p3.
            Console.WriteLine("Original values of p1, p2, p3:");
            Console.WriteLine("   p1 instance values: ");
            DisplayValues(p1);
            Console.WriteLine("   p2 instance values:");
            DisplayValues(p2);
            Console.WriteLine("   p3 instance values:");
            DisplayValues(p3);

            // Change the value of p1 properties and display the values of p1,
            // p2 and p3.
            p1.age = 32;
            p1.name = "Frank";
            p1.id.idNumber = 7878;
            Console.WriteLine("\nValues of p1, p2 and p3 after changes to p1:");
            Console.WriteLine("   p1 instance values: ");
            DisplayValues(p1);
            Console.WriteLine("   p2 instance values (reference values have changed):");
            DisplayValues(p2);
            Console.WriteLine("   p3 instance values (everything was kept the same):");
            DisplayValues(p3);
        }
        public static void DisplayValues(Identity p)
        {
            Console.WriteLine("      Name: {0:s}, Age: {1:d}",
                p.name, p.age);
            Console.WriteLine("      ID#: {0:d}", p.id.idNumber);
        }
    }
}