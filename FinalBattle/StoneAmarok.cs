﻿using FinalBattle;

public class StoneAmarok : Character
{
    public override string Name => "Stone Amarok";

    public override IAttack BasicAttack => new Bite();

    public StoneAmarok() : base(4)
    {
        DefensiveModifier = new StoneArmor();
    }
}

public class Bite : IAttack
{
    public string Name => "BITE";

    public AttackData Create() => new AttackData(1);
}

public class StoneArmor : IAttackModifier
{
    public string Name => "STONE ARMOR";
    public AttackData Modify(AttackData input)
    {
        if (input.Damage == 0) return input;
        ColoredConsole.WriteLine($"{Name} reduced the attack by 1 point.", ConsoleColor.Yellow);
        return input with { Damage = input.Damage - 1 };
    }
}