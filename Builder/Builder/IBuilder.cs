namespace DesignPatterns.Builder
{
    public interface IBuilder
    {
        void Reset();
        void SetDough(string dough);
        void SetIngredients(List<string> ingredients);
    }
}
