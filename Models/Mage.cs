namespace Models;

public class Mage : Character, IHealer
{
    public Mage(string name) : base(name, 70) { }

    public override void Attack(Character target, Random random)
    {
        int damage = random.Next(5, 13);
        target.TakeDamage(damage);
        Console.WriteLine($"{Name} casts on {target.Name} for {damage} damage!");
    }

    public void Heal(Character target)
    {
        target.RestoreHealth(15);
        Console.WriteLine($"{Name} heals {target.Name} for 15 HP!");
    }
}
