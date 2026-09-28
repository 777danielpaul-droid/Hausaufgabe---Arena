using Models;

var random = new Random();

var playerParty = new List<Character>
{
    new Warrior("Thorin"),
    new Mage("Gandalf"),
    new Rogue("Legolas")
};

var enemies = new List<Character>
{
    new Warrior("Orc Warlord"),
    new Rogue("Goblin Assassin")
};

Console.WriteLine("=== Console RPG Arena ===");
Console.WriteLine("Battle begins!\n");
