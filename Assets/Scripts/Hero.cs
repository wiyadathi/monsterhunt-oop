
class Hero
{
    //Attributes
    public string Name;

    //Property
    private int health; 
    public int Health {  
        get { return health; } 
        set { 
            if (value >= 0) health = value;
            else health = 0;
        }
    }

    public int Gold;

    //Constructor to crete abject = ผู้รับเหมาที่จะสร้าง Object จาก Blueprint
    public Hero(string newName, int newHp)
    {
        Name = newName; 
        Health = newHp;
        Gold = 0;
    }

}