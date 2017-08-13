using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateTiles : MonoBehaviour {

    public static int gameTileColumns = 11;// how many columns of game tiles
    public int gameTileRows = 11;// how many rows of game tiles
    public Vector2 gameTileStartingPosition = new Vector2(-5, -5);// starting position (x , y) UPPER LEFT CORNER
    public GameObject gameTileSprite; // the game sprite that will be cloned

    public int backgroundTileColumns = 23;// how many columns of background tiles
    public int backgroundTileRows = 13;// how many rows of background tiles
    public Vector2 backgroundTileStartingPosition = new Vector2 (-11,-6);// starting position (x , y) UPPER LEFT CORNER
    public GameObject backgroundTileSprite; // the background sprite that will be cloned

    void Start()
    {
        // enable sprites
        gameTileSprite.SetActive(true);
        backgroundTileSprite.SetActive(true);

        // creates the background tiles
        backgroundTileSprite.gameObject.transform.position = backgroundTileStartingPosition;// get in the right spot before creating the background tiles
        for (int i = 0; i < backgroundTileColumns; i++)
        {
            for (int j = 0; j < backgroundTileRows; j++)
            {
                // creates a clone
                float cloneX = backgroundTileStartingPosition.x + i;
                float cloneY = backgroundTileStartingPosition.y + j;
                Instantiate(backgroundTileSprite, new Vector2(cloneX, cloneY), Quaternion.identity);
            }
        }

        // creates the game tiles
        gameTileSprite.gameObject.transform.position = gameTileStartingPosition;// get in the right spot before creating the game tiles
        for (int i = 0; i < gameTileColumns; i++) {
            for (int j = 0; j < gameTileRows; j++) {
                // creates a clone
                float cloneX = gameTileStartingPosition.x + i;
                float cloneY = gameTileStartingPosition.y + j;
                Instantiate(gameTileSprite, new Vector2(cloneX, cloneY), Quaternion.identity);
            }
        }
    }
}
