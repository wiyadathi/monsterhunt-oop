
using UnityEngine.UIElements.Experimental;

class Hero
{
    //Attributes
    private string name;
    public string Name
    {  
       get { return name; }
       set { if (value == "") name = "Hero";
             else name = value;
       }
    }

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
            else gold = value; ;
        }
    }

    //Constructor to crete abject = ผู้รับเหมาที่จะสร้าง Object จาก Blueprint
    public Hero(string newName, int newHp)
    {
        Name = newName; 
        Health = newHp;
        Gold = 0;
    }

}