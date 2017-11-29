using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool IsAlive = true;

	// Use this for initialization
	void Start ()
    {
        //IsAlive = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
        CheckIfAlive();
	}

    void CheckIfAlive()
    {
        if(!IsAlive)
            print("The player is not alive!");
    

        else
            print("The player is alive!");
    }
}
