using Animals.Models;

internal class Dog : Animal
{
    private string name;
    private string favoriteFood;

    public Dog(string name, string favoriteFood) :base(name, favoriteFood)
    {
    }

        public override string ExplainSelf()
    {
        return base.ExplainSelf() + "\nBORK";
    }

    

}
