namespace Animals.Models;

public abstract class Animal
{
    public string name { get; set; }
    public string favoriteFood { get; set; }

    public Animal(string name, string favoriteFood)
    {
        this.name = name;
        this.favoriteFood = favoriteFood;
    }

    public virtual string ExplainSelf()
    {
        return $"I am {this.name} an my fovourable food is {this.favoriteFood}";
    }
}
