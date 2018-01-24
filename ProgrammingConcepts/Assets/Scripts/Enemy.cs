using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int maxHealth;
    [HideInInspector] public int currentHealth;

	void Start ()
    {
        currentHealth = maxHealth;
        Damage(10, GameManager.gm.playerOne);
	}
	
    void Damage(int amountOfDamage, GameObject player)
    {
        Player playerScript = player.GetComponent<Player>();
        playerScript.currentHealth -= amountOfDamage;
        Debug.Log("Current Player Health = " + playerScript.currentHealth);
    }
}
