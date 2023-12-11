using Raiding;
using Raiding.Models;

internal class Rogue : Fighter
{
    public Rogue(string name) : base(name)
    {
    }

    public override int Power => 80;

    public override string CastAbility()
    {
        return $"{base.CastAbility()}";
    }
}