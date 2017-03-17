using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DeathBrick : MonoBehaviour
{


    // Use this for initialization
    void Start()
    {

    }

    void OnCollisionEnter2D(Collision2D coll)
    {

        FindObjectOfType<BallLevel2>().GetOut();
        FindObjectOfType<BallLevel2>().SetLives();
        FindObjectOfType<BallLevel2>().livesValue = GameObject.Find("LivesValue").GetComponent<Text>();

    }


}
