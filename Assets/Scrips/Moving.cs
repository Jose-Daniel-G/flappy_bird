using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    private Rigidbody2D rb;
    void Start()
    {   rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(GameController.Instance.speed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(GameController.Instance.gameOver){
            rb.velocity = Vector2.zero;
        }
    }
}
