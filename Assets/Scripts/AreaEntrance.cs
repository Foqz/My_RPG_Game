using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaEntrance : MonoBehaviour {
    private static bool gameStarted;
    public string transitionName;


	// Use this for initialization
	void Start ()
    {
        if(gameStarted)
        {
            if (transitionName == PlayerController.instance.areaTransitionName)
            {
                PlayerController.instance.transform.position = transform.position;
            }
        }
        else
        {
            gameStarted = true;
        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
