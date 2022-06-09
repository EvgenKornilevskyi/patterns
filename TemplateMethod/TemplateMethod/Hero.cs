namespace DesignPatterns.TemplateMethod
{
    public abstract class Hero
    {
        public void DefendAgainstAttack()
        {
            PickWeapon();
            DefenseAction();
            MoveToSafety();
        }
        public abstract void PickWeapon();
        public abstract void DefenseAction();
        public abstract void MoveToSafety();
    }
}
