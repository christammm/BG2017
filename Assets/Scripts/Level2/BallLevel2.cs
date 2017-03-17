using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallLevel2 : MonoBehaviour
{

    public Vector2 startingVelocity = new Vector2(15, -20);
    private Vector3 startingPosition;
    public GameObject gameOverSign;
    public GameObject youWinSign;
    public Text livesValue;
    public Text pointsValue;

    public int lives = 3;
    public int score = 0;
    public int numBricks = 0;

    void Start()
    {
        SetLives();
        SetScore();
        youWinSign.SetActive(false);
        startingPosition = transform.position;
        GetComponent<Rigidbody2D>().velocity = startingVelocity;
        livesValue = GameObject.Find("LivesValue").GetComponent<Text>();
    }



    //Update position
    void Update()
    {
        if (transform.position.y < -4.5f)
        {
            GetOut();
            SetLives();
        }
        if (Input.GetButtonDown("Jump"))
        {
            GetComponent<Rigidbody2D>().velocity = startingVelocity;
        }
    }


    //Stop game and decrement life
    public void GetOut()
    {
        Debug.Log("You are out");
        lives = lives - 1;
        transform.position = startingPosition;
        GetComponent<Rigidbody2D>().velocity = new Vector2();


        if (lives == 0)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        gameOverSign.SetActive(true);
    }

    public void SetLives()
    {
        livesValue.text = "" + lives;
    }

    void SetScore()
    {
        pointsValue.text = "" + score;
    }


    public void IBrokeABrick()
    {
        score += 500;
        SetScore();
        var bricksLeft = FindObjectsOfType<BrickLevel2>().Length;

        if (bricksLeft == 0)
        {
            youWinSign.SetActive(true);
            score += 500;
        }
    }

    public void IBeatABoss()
    {
        score += 500000;
        SetScore();
        var BossLeft = FindObjectsOfType<Boss>().Length;

        if (BossLeft == 0)
        {
            youWinSign.SetActive(true);
            score += 500;
        }
    }
}
