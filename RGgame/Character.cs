namespace RGgame;

public class Character
{
    public int hp  { get; set; }
    public int ap { get; set; }
    public int dp { get; set; }
    
    public event EventHandler<BattleEventArgs> OnAttack;
    
    public void attack(Character target)
    {
        int damage = ap - target.dp;
        if (damage < 0) damage = 0;
        target.hp -= damage;
        
        OnAttack?.Invoke(this, new BattleEventArgs
        {
            attacker = this,
            target = target,
            damage = damage
        });
    }
}

public class Wizard : Character
{
    public Wizard() { hp = 200; ap = 60; dp = 50; }
}

public class Warrior : Character
{
    public Warrior() { hp = 150; ap = 95; dp = 30; }
}