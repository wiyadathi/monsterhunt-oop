using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    Hero hero = new Hero("HeroA", 75, 15);

    //declare Monster list
    private List<Monster> monsters = new List<Monster>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Setup();
        Run();
      
        
    }// end start

    void Setup()
    {
        //create monsters
        monsters.Add(new Monster("Orc", 25, 5, 3));
        monsters.Add(new Monster("Goblin", 30, 10, 6));
        monsters.Add(new Monster("Dragon", 35, 15, 10));

        Debug.Log("**** Battle Arena ****");
        Debug.Log("-- Monsters Data --: ");

        //display monsters
        foreach (Monster m in monsters) m.ShowStat();

    }

    void Run()
    {
        while (hero.IsAlive() && monsters.Count > 0)
        {
            hero.ShowStat();

            // random a Monster
            Monster enemy = monsters[Random.Range(0, monsters.Count)];
            Debug.Log($"Enemy: {enemy.Name} appears!");

            //Battle
            Battle.Fight(hero, enemy);

            //check who win each turn
            if (hero.IsAlive() && !enemy.IsAlive())
            {
                Debug.Log($"{hero.Name} defeated {enemy.Name}!");

                //hero gets reward golds
                hero.EarnGold(enemy.DropReward());
                monsters.Remove(enemy);
            }
            else if (!hero.IsAlive())
            {
                Debug.Log($"{hero.Name} has fallen....Game Over!");
            }
        } //end while (Game Loop

        //hero defeated all monsters -> win
        if (hero.IsAlive())
        {
            Debug.Log($"{hero.Name} has defeated all monsters!!");
        }
    }
}



/////////////////////////////////////////////
/*        Monster orc = new Monster("Orc", 25, 5, 3);
        Monster goblin = new Monster("Goblin", 30, 10, 6);
        Monster dragon = new Monster("Dragon", 35, 15, 10);*//*

        //print attributes to see if the object actually created.
        Debug.Log("Hero name: " + hero.Name + ", Health: " 
            + hero.Health + ", Gold: " + hero.Gold);

        Debug.Log("Monster Name: " + orc.Name + ", HP: " + orc.Health);
*//*        Debug.Log("Monster Name: " + goblin.Name + ", HP: " + goblin.Hp);
        Debug.Log("Monster Name: " + dragon.Name + ", HP: " + dragon.Hp);
*//*
        //Main class: edit hero's health (public) fields
        hero.Health = -50;
        hero.Gold = 100000;
        Debug.Log("Hero name: " + hero.Name + ", Health: " + hero.Health + ", Gold: " + hero.Gold);

        //hero.Name = "";

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

        orc.ShowStat();
        dragon.ShowStat();*/
