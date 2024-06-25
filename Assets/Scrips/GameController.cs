using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : Singleton<GameController>
{
 public bool gameOver = false; 
 public float speed = -3f;

 private int score = 0;

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Score()
    {
        score++;
    }
    public void Lose()
    {
        gameOver = true;
    }
}
