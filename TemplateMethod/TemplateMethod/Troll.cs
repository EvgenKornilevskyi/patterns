using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplateMethod
{
    public class Troll : Hero
    {
        public override void DefenseAction()
        {
            Console.WriteLine("Defend with bar");
        }

        public override void MoveToSafety()
        {
            Console.WriteLine("Return to mountain");
        }

        public override void PickWeapon()
        {
            Console.WriteLine("Pick bar");
        }
    }
}
