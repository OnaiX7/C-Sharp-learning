namespace RGgame;

public class BattleEventArgs : EventArgs
{
    public Character attacker { get; set; }
    public Character target { get; set; }
    public int damage { get; set; }
}