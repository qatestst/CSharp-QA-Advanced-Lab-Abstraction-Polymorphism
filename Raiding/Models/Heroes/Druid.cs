using Raiding.Models;

internal class Druid : Healer 
{
    private string name;

    public Druid(string name) : base(name)
    {
        this.name = name;
        
    }

    public override int Power => 80;

    public override string CastAbility()
    {
        return $"{base.CastAbility()}";
    }
}