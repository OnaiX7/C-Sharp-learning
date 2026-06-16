namespace RGgame;

public interface IBattleSystem
{
    void attack(Character target);
    void defend(Character attacker);
}