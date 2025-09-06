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

    }


}
