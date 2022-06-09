namespace DesignPatterns.TemplateMethod
{
    public class Pirate : Hero
    {
        public override void DefenseAction()
        {
            Console.WriteLine("Defend with knife");
        }

        public override void MoveToSafety()
        {
            Console.WriteLine("Return to ship");
        }

        public override void PickWeapon()
        {
            Console.WriteLine("Pick knife");
        }
    }
}
