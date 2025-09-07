using UnityEngine;

public abstract class Character
{
    public string Name { get; set; }

    //Property: health Cannot be less than 0
    private int health;
    public int Health
    {
        get => health;
        set => health = (value < 0) ? 0 : value;
    }

    // public int AttackPower
    public int AttackPower { get; set; }

    //Constructor to create abject = ผู้รับเหมาที่จะสร้าง Object จาก Blueprint
    public Character(string newName, int newHp, int atkPower)
    {
        Name = newName;
        Health = newHp;
        AttackPower = atkPower;
    }

    //Behaviors-Methods
    public void TakeDamage(int newDamage)
    {
        Health -= newDamage;
        Debug.Log($"{Name} takes {newDamage} damage. HP left: {Health}");
    }

    public bool IsAlive()
    {
        return Health > 0;
    }

}
