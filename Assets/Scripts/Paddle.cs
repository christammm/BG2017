using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    Rigidbody2D rigidBody;
    public float speed = 5;

    void Start () {
        rigidBody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame 
    void Update () {
        float x = Input.GetAxisRaw("Horizontal");
        x = x * speed;
        rigidBody.velocity = new Vector2(x, 0);
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.GetComponent<Boss>() == true)
        {
            GameObject.FindObjectOfType<BallLevel2>().GetOut();
            GameObject.FindObjectOfType<BallLevel2>().SetLives();
        }
    }
}
