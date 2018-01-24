using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager gm;

    private void Awake()
    {
        if (!gm)
        {
            gm = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    [Header("Player Object")]
    public GameObject playerOne;
    public GameObject playerTwo;

    [Header("Enemy Objects")]
    public GameObject enemyOne;
    public GameObject enemytwo;
}
