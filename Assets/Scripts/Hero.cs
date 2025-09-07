
using UnityEngine;

class Hero
{
    //Attributes
    public string Name { get; set; }

    //private string name;
    /*    public string Name
    {  
       get { return name; }
       set { if (!string.IsNullOrEmpty(value)) name = value;
            else name = "Unknown Hero"; 
       }
    }*/

    //Property: health Cannot be less than 0
    private int health; 
    public int Health  
    {          
        get => health; 
        set => health = (value < 0) ? 0 : value;
    }

/*    public int Health   //Propertiy
    {
        get { return health; }
        set
        {
            if (value < 0) health = 0;
            else health = value;
        } // Monster can't have negative HP
    }*/

    private int gold;
/*    public int Gold  //Propertiy
    {
        get { return gold; }
        set
        {
            if (value > 999) gold = 999; //max gold cap
            else if(value < 0) gold = 0; //no negative gold
            else gold = value; 
        }
    }*/
    public int Gold
    {
        get => gold;
        set => gold = (value < 0) ? 0 : (value > 999 ? 999 : value);
    }

    // public int AttackPower
    public int AttackPower { get; set; }

    //Constructor to create abject = ผู้รับเหมาที่จะสร้าง Object จาก Blueprint
    public Hero(string newName, int newHp)
    {
        Name = newName; 
        Health = newHp;
        Gold = 0;
    }

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