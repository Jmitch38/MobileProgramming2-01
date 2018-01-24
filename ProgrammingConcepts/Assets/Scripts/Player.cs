using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int maxHealth;
    [HideInInspector] public int currentHealth;

	void Start ()
    {
        currentHealth = maxHealth;
        Damage(10, GameManager.gm.enemyOne);
	}
	
	void Damage(int amountOfDamage, GameObject enemy)
    {
        Enemy enemyScript = enemy.GetComponent<Enemy>();
        enemyScript.currentHealth -= amountOfDamage;
        Debug.Log("Current Enemy Health = " + enemyScript.currentHealth);
    }
}
