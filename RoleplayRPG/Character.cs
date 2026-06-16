namespace RoleplayRPG;

public class Character
{
    public string role;
    public List<string> weaponsList = new List<string>();
    public List<string> armorList = new List<string>();
    public List<string> potionsList = new List<string>();
    
    public string listWeapons()
    {
        return string.Join(", ", weaponsList);
    }
    
    public string listArmor()
    {
        return string.Join(", ", armorList);
    }
    
    public string listPotions()
    {
        return string.Join(", ", potionsList);
    }
}

public class Wizard : Character
{
    public Wizard()
    {
        role  = "Wizard";
        weaponsList.Add("Magic staff");
        weaponsList.Add("Ice scepter");
        armorList.Add("Wizard hat");
        armorList.Add("Mystic robe");
        armorList.Add("Voidwalker boots");
        potionsList.Add("Mana potion");
        potionsList.Add("Healing potion");
    }
}

public class Warrior : Character
{
    public Warrior()
    {
        role = "Warrior";
        weaponsList.Add("Iron sword");
        weaponsList.Add("Battle axe");
        armorList.Add("Iron helmet");
        armorList.Add("Steel chestplate");
        armorList.Add("Iron boots");
        potionsList.Add("Strength potion");
        potionsList.Add("Healing potion");
    }
}