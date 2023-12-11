using Raiding;
using Raiding.Models;

internal class Paladin : Healer
{
    public Paladin(string name) : base(name)
    {
    }

    public override int Power => 100;

    public override string CastAbility()
    {
        return $"{base.CastAbility()}";
    }
}