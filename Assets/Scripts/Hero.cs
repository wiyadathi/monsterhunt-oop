
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

    //Property
    private int health; 
    public int Health   //Propertiy
    {          
        get { return health; } 
        set { 
            if (value >= 0) health = value;
            else health = 0;
        }
    }

    private int gold;
    public int Gold  //Propertiy
    {
        get { return gold; }
        set
        {
            if (value > 9999) gold = 9999; //max gold cap
            else if(value < 0) gold = 0; //no negative gold
            else gold = value; 
        }
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
            Debug.Log("Received " + amount + " golds" );
            ShowStat();
        }
        else { Debug.Log("Invalid gold amount"); }
    }


}