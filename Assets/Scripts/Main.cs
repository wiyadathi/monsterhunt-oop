using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //create hero object
        Hero hero = new Hero("HeroA", 75);

        Monster orc = new Monster("Orc", 25);
        Monster goblin = new Monster("Goblin", 30);
        Monster dragon = new Monster("Dragon", 35);

        //print attributes to see if the object actually created.
        Debug.Log("Hero name: " + hero.Name + ", Health: " 
            + hero.Health + ", Gold: " + hero.Gold);

        Debug.Log("Monster Name: " + orc.Name + ", HP: " + orc.Hp);
/*        Debug.Log("Monster Name: " + goblin.Name + ", HP: " + goblin.Hp);
        Debug.Log("Monster Name: " + dragon.Name + ", HP: " + dragon.Hp);
*/
        //Main class: edit hero's health (public) fields
        hero.Health = -50;
        hero.Gold = 100000;
        Debug.Log("Hero name: " + hero.Name + ", Health: " + hero.Health + ", Gold: " + hero.Gold);

        hero.Name = "";
        
        Debug.Log("Hero name: " + hero.Name + ", Health: " + hero.Health + ", Gold: " + hero.Gold);

        //test class and methods
        hero.Health = 50;
        hero.ShowStat();
        int damage = 10;
        hero.TakeDamage(damage);
        hero.ShowStat();
        if (hero.IsAlive())
        {
            Debug.Log("Continue Battle...");
        }

        //Main: assume the hero earn 10 golds
        int goldReward = 10;
        hero.Gold = 0;
        hero.EarnGold(goldReward);

        //Main: test AttackPower auto-property
        hero.AttackPower = -5;
        hero.ShowStat();
    }


}
