using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityScript.Lang;

public class SpawnEnemy : MonoBehaviour {

    public GameObject Sniper;
    public Vector2 offScreen = new Vector2 (0F,99F);
    public bool enemyTurn = false;
    private bool occupied = false;

    void Start ()
    {
        // enable sprites
        Sniper.SetActive(true);
        Sniper.transform.position = offScreen;
        print("Start Your Turn");
    }

    void Update () {
        //////////////////////////////////////////////////////////////////////////////////
        if (enemyTurn)
        {
            print("Opponent's Turn");
            Sniper.GetComponent<SpriteRenderer>().flipY = true;
            Sniper.GetComponent<SpriteRenderer>().color = new Color(0.5F, 0.5F, 255);
            
            Instantiate(Sniper, new Vector2(Random.Range(-5, 6), Random.Range(3, 6)), Quaternion.identity);
            occupied = true;

            enemyTurn = false;
            print("Your Turn");
        }

    }
}
