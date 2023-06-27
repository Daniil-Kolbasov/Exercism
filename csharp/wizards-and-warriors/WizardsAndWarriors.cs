using System;

abstract class Character
{
    private string characterType;
    
    protected Character(string characterType)
    {
        this.characterType = characterType;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable() => false;

    public override string ToString() => $"Character is a {characterType}";
}

class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target)
    {
        if (target.Vulnerable()) return 10;
        else return 6;
    }
}

class Wizard : Character
{
    private bool prepareSpell;

    public Wizard() : base("Wizard")
    {
        prepareSpell = false;
    }

    public override int DamagePoints(Character target)
    {
        if (prepareSpell)
        {
            prepareSpell = false;
            return 12;
        }
        else return 3;
    }

    public void PrepareSpell() => prepareSpell = true;

    public override bool Vulnerable()
    {
        if (!prepareSpell) return true;
        else return false;
    }
}
