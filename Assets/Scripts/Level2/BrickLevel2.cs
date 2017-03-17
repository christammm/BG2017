using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BrickLevel2 : MonoBehaviour
{



    // Use this for initialization
    void Start()
    {

    }

    void OnCollisionEnter2D(Collision2D coll)
    {

            gameObject.SetActive(false);
            FindObjectOfType<BallLevel2>().IBrokeABrick();
      
    }


}
