using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Brick : MonoBehaviour {

    public int COUNT = 0;

    // Use this for initialization
    void Start () {
		
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
    
        if (COUNT > 2) {
            gameObject.SetActive(false);
            COUNT = 0;
        } else
        {
            COUNT = COUNT + 1;
        }
    }
}
