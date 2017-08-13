using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierWalk : MonoBehaviour {

    private Animator myAnimator;
    


    void Start()
    {
        myAnimator = GetComponent<Animator>();
    }


    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Keypad1))
        {
            myAnimator.enabled = !myAnimator.enabled;
        }
    }

}
