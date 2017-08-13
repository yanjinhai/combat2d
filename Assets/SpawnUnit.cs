using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnUnit : MonoBehaviour {

    private bool occupied = false;
    public bool enemyTurn = false;
    public Vector2 offScreen = new Vector2(0F, 99F);
    public GameObject Sniper;

    private int myCurrency = 1;
    private int enemyCurrency = 1;
    private int turnCount;

    // Use this for initialization
    void Start () {
        Sniper.SetActive(true);
        Sniper.transform.position = offScreen;
        print("Your Turn First");
    }

    void Update()
    {
        if (enemyTurn)// && this.transform.position.y >= 3)
        {
            //print("a");
            Sniper.GetComponent<SpriteRenderer>().flipY = true;
            Sniper.GetComponent<SpriteRenderer>().color = new Color(0.5F, 0.5F, 255);
            for(int i = 0; i < enemyCurrency; i++)
            {
                Instantiate(Sniper, new Vector2(Random.Range(-5, 6), Random.Range(3, 6)), Quaternion.identity);//Instantiate(Sniper, this.transform.position, Quaternion.identity);
                occupied = true;
            }
            enemyCurrency++;
            enemyTurn = false;

            EnemyAI.Fight();

            print("Your Turn");
            turnCount = myCurrency;
        }
    }

    void OnMouseDown()
    {
        if (this.transform.position.y <= -3 && !occupied && !enemyTurn)
        {
            Sniper.GetComponent<SpriteRenderer>().flipY = false;
            Sniper.GetComponent<SpriteRenderer>().color = new Color(255, 0.5F, 0.5F);
            Instantiate(Sniper, this.transform.position, Quaternion.identity);
            occupied = true;
            myCurrency--;
            if (myCurrency == 0)
            {
                enemyTurn = true;
                print("Opponent's Turn");
                myCurrency = turnCount + 1;
            }
        }
    }
}