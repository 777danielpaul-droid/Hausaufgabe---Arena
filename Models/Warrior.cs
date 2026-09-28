namespace Models;

public class Warrior : Character
{
    public Warrior(string name) : base(name, 100) { }

    public override void Attack(Character target, Random random)
    {
        int damage = random.Next(8, 16);
        target.TakeDamage(damage);
        Console.WriteLine($"{Name} strikes {target.Name} for {damage} damage!");
    }
}
