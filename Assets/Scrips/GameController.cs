using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : Singleton<GameController>
{
    public Text scoreText;
    public bool gameOver = false;
    public float speed = -3f;

    private int score = 0;

    // Update is called once per frame
    void Update()
    {

    }
    public void Score()
    {
        if (gameOver)
        {
            return;
            score++;
            scoreText.text =  score.ToString();
        }
    }
    public void Lose()
    {
        gameOver = true;
        scoreText.text = "Game Over";
    }
}
