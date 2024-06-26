using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundRepeat : MonoBehaviour
{   private BoxCollider2D groundCollider;
    private float width;
    void Start()
    { groundCollider = GetComponent<BoxCollider2D>();
      width = groundCollider.size.x;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x<-width){
            Reposition();
        }
    }
    private void Reposition(){
        Vector2 vector = new Vector2(width*2f,0);
        transform.position = (Vector2)transform.position + vector;
    }
}
