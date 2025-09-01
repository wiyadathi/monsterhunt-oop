using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //create hero object
        Hero hero = new Hero("HeroA", 75);
        
        //print attributes to see if the object actually created.
        Debug.Log("Hero name: " + hero.name + ", Health: " 
            + hero.health + ", Gold: " + hero.gold);
    }


}
