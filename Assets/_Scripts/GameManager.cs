using UnityEngine;
using UnityEngine.Events;
public class GameManager : MonoBehaviour
{
    public static UnityAction<int> OnScoreChanged;
    public static UnityAction<int> OnHealthChanged;
    private int score = 0;
    private int health = 100;



    private void Update()
    {
  
        if (Input.GetKeyDown(KeyCode.Space)) DodajScore(10);

        if (Input.GetKeyDown(KeyCode.D)) PrimiDamage(10);

        if (Input.GetKeyDown(KeyCode.H)) Heal(10);

    }


    public void DodajScore(int amount)
    {
        score += amount;
        OnScoreChanged?.Invoke(score);
    }

    public void PrimiDamage(int damage)
    {
        health -= damage;
        if (health < 0) health = 0;
        OnHealthChanged?.Invoke(health);
    }

    public void Heal(int heal)
    {
        health += heal;
        if (health > 100) health = 100;
        OnHealthChanged?.Invoke(health);
    }

}
