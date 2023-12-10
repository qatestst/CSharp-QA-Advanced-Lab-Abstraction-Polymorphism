using Animals.Models;

public class Cat : Animal
{
    private string name;
    private string favoriteFood;

    public Cat(string name, string favoriteFood) : base(name, favoriteFood)
    {
    }

    
    public override string ExplainSelf()
    {
        return base.ExplainSelf() + "\nMEEOW";
    }
}
