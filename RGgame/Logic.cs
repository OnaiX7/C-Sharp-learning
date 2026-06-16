namespace RGgame;

public class Logic
{
    public void RunLogic()
    {
        this.GameExecution();
    }

    public void GameExecution()
    {
        var Engin = new Warrior();
        var Thomas = new Wizard();

        Engin.OnAttack += GameEventsWrite;
        Engin.attack(Thomas);
    }

    public void GameEventsWrite(object sender, BattleEventArgs e)
    {
        string attackerName = e.attacker.GetType().Name;
        string targetName = e.target.GetType().Name;
        
        if (e.attacker is Warrior && e.target is Wizard)
        {
            Console.WriteLine($"{attackerName} schlägt mit dem Schwert zu! {e.damage} Schaden → {targetName} HP: {e.target.hp}");
        }
        else if (e.attacker is Wizard && e.target is Warrior)
        {
            Console.WriteLine($"{attackerName} wirft einen Zauber! {e.damage} Schaden → {targetName} HP: {e.target.hp}");
        }
    }
}