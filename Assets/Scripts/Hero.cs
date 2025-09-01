
class Hero
{
    //Attributes
    public string name;
    int health;
    int gold;

    //Constructor to crete abject = ผู้รับเหมาที่จะสร้าง Object จาก Blueprint
    public Hero(string newName, int newHp)
    {
        name = newName; 
        health = newHp;
        gold = 0;
    }


}