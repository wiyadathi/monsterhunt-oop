using UnityEngine;
//using System.Diagnostics;

class Monster
{
    public string Name;
    public int Hp;
    private bool defeated;
    
    public Monster(string newName, int newHp)
    {
        Name = newName;
        Hp = newHp;
        defeated = false;
    }

    public void TakeDamage()
    {
        
    }
}

