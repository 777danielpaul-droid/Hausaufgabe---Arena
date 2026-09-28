namespace Models;

public abstract class Character
{
    public string Name { get; }
    public int MaxHealth { get; }
    public int Health { get; private set; }
    public bool IsAlive => Health > 0;

    protected Character(string name, int maxHealth)
    {
        Name = name;
        MaxHealth = maxHealth;
        Health = maxHealth;
    }

    public void RestoreHealth(int amount)
    {
        Health = Math.Min(MaxHealth, Health + amount);
    }

    public void TakeDamage(int amount)
    {
        Health = Math.Max(0, Health - amount);
    }

    public abstract void Attack(Character target, Random random);
}
