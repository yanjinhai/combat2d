using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {

    public GameObject[] Snipers;
    public InstantiateTiles _InstantiateTiles;

    // Use this for initialization
    void Start () {
        Snipers = GameObject.FindGameObjectsWithTag("sniper");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public static void Fight()
    {

        for(int i = 0; i < InstantiateTiles.gameTileColumns; i++)
        {
            if (/* 2 snipers are on the same column facing opposite directions*/)
            {
                //destroy them
            }
        }
        
    }

}
