
using UnityEngine;

class Hero : Character
{
    private int gold;
    public int Gold
    {
        get => gold;
        set => gold = (value < 0) ? 0 : (value > 999 ? 999 : value);
    }

    //Constructor 
    public Hero(string newName, int newHp, int atkPower): base(newName, newHp, atkPower)
    {
        Gold = 0;
    }

    /*
    //Behaviors-Methods
    public void TakeDamage(int newDamage) 
    { 
        Health -= newDamage;
        Debug.Log($"{Name} takes {newDamage} damage. HP left: {Health}");
    }

    public bool IsAlive() 
    {
        return health > 0;
    }
*/
    public void ShowStat()
    {
        Debug.Log("Hero name: " + Name + ", Health: " + Health + 
            ", Gold: " + Gold + ", AttackPower: " + AttackPower);
    }

    public void EarnGold(int amount) 
    {
        if (amount > 0)
        {
            Gold += amount;
            Debug.Log($"{Name} earned {amount} golds. Total golds: {Gold}" );
        }
        else { Debug.Log("Invalid gold amount"); }
    }


}