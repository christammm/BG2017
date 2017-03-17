using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Boss : MonoBehaviour
{

    public float width = 3;
    public float height = 3;
    public int health;
    public Text healthValue;

    // Use this for initialization
    void Start()
    {
        health = 50;
        healthValue = GameObject.Find("HealthValue").GetComponent<Text>();
        SetHealth();
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        

        health -= 1;
        SetHealth();
        Debug.Log("Health = " + health);
        if (health == 0)
        {
            gameObject.SetActive(false);
            FindObjectOfType<BallLevel2>().IBeatABoss();
        }



    }

    void SetHealth()
    {
        healthValue.text = "" + health;
    }



}
