namespace Models;

public class Rogue : Character
{
    public Rogue(string name) : base(name, 80) { }

    public override void Attack(Character target, Random random)
    {
        int damage = random.Next(6, 14);
        target.TakeDamage(damage);
        Console.WriteLine($"{Name} strikes {target.Name} for {damage} damage!");
    }
}
