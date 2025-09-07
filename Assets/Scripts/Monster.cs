using UnityEngine;
//using System.Diagnostics;

class Monster
{
    public string Name { get; set; }

    //Property: health Cannot be less than 0
    private int health;
    public int Health
    {
        get => health;
        set => health = (value < 0) ? 0 : value;
    }

    public int AttackPower { get; set; }

    private int lootGold;
    public int LootGold 
    {
        get { return lootGold; }
        set { lootGold = (value < 0) ? 0 : value; }
    }

    private bool defeated;
    
    public Monster(string newName, int newHp, int atkPower, int newLootGold)
    {
        Name = newName;
        Health = newHp;
        AttackPower = atkPower;
        LootGold = newLootGold;
        defeated = false;
    }

    public void TakeDamage(int newDamage)
    {
        Health -= newDamage;
        Debug.Log($"{Name} takes {newDamage} damage. HP left: {Health}");
    }

    public bool IsAlive()
    {
        return health > 0;
    }
}

