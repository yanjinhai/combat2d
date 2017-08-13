using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateUnit : MonoBehaviour {

    private bool occupied = false;
    public bool enemyTurn = false;
    public Vector2 offScreen = new Vector2(0F, 99F);
    public GameObject Sniper;

    void Start()
    {

        Sniper.SetActive(true);
        Sniper.transform.position = offScreen;
        print("Your Turn First");
    }

    void Update()
    {
        if (enemyTurn)
        {
            if (this.transform.position.y >= 3 && !occupied)
            {

            }
        }
        else
        {
            if (Input.GetMouseButtonDown(0)) 
            {
                print("clicked");
                if (Mathf.Round(Input.mousePosition.y) == this.transform.position.y && Mathf.Round(Input.mousePosition.x) == this.transform.position.x)//here's the problem
                {
                    print("Here!");
                    if (this.transform.position.y <= -3 && !occupied)
                    {
                        Sniper.GetComponent<SpriteRenderer>().flipY = false;
                        Sniper.GetComponent<SpriteRenderer>().color = new Color(255, 0.5F, 0.5F);
                        Instantiate(Sniper, this.transform.position, Quaternion.identity);
                        enemyTurn = true;
                        print("Opponent's Turn");
                        occupied = true;
                    }
                }
                else
                {
                    print("You may only place troops on the bottom 3 rows.");
                }
            }
        }
       
    }

    
}
