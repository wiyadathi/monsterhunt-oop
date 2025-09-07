using UnityEngine;

public static class Battle
{
    public static void Fight(Hero hero, Monster monster) 
    {
        Debug.Log($">>> Battle Start!: {hero.Name} vs. {monster.Name}");

        while (hero.IsAlive() && monster.IsAlive())
        {
            hero.Attack(monster);
            if (!monster.IsAlive()) break;

            monster.Attack(hero);
        }
            
        if (hero.IsAlive()) Debug.Log($"{hero.Name} wins!");
        else Debug.Log($"{monster.Name} wins!");
    }
}
