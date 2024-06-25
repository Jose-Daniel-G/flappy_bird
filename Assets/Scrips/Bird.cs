using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float force = 400f;
    private Rigidbody2D rb; 
    private bool isDead = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isDead)
        {
           if (Input.GetMouseButtonDown(0))
           {
            rb.velocity = Vector2.zero;
            rb.AddForce(new Vector2(0, force));
           } 
        }
    }
    void OnCollisionEnter2D()
    {
        isDead = true;
        rb.velocity = Vector2.zero;
    }
}
