
class Hero
{
    //Attributes
    public string Name;
    public int Health;
    public int Gold;

    //Constructor to crete abject = ผู้รับเหมาที่จะสร้าง Object จาก Blueprint
    public Hero(string newName, int newHp)
    {
        Name = newName; 
        Health = newHp;
        Gold = 0;
    }

}