namespace RoleplayRPG;

public class Logic
{
    public void RunLogic()
    {
        this.ShowcaseCharacter();
    }

    public void ShowcaseCharacter()
    {
        var Engin = new Wizard();

        Console.WriteLine($"{Engin.role} Engin:");
        Console.WriteLine($"Weapons: {Engin.listWeapons()}");
        Console.WriteLine($"Armor: {Engin.listArmor()}");
        Console.WriteLine($"Potions: {Engin.listPotions()}");
    }
}