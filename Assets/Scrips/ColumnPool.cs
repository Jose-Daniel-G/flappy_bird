using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnPool : MonoBehaviour
{
    public GameObject columnPrefab;
    public GameObject[] columns;
    public float spawnRate = 6f;
    public float yMin = 8f;
    public float yMax = -5f;

    private Vector2 defaultPos = new Vector2(-100,-100);
    private float time;
    private int currentColumn = 0;

    void Start(){ 
        columns = new GameObject[5];
        for (int i = 0; i < columns.Length; i++)
        {
            columns[i] = Instantiate(columnPrefab, defaultPos, Quaternion.identity);
        }
    }
    void Update(){
        time += Time.deltaTime;
        if(!GameController.Instance.gameOver && time>=spawnRate){
            time = 0;
         float y = Random.Range(yMin, yMax);
         columns[currentColumn].transform.position = new Vector2(10f, y);
         currentColumn++;
         if (currentColumn>=columns.Length)
         {
            currentColumn = 0;
         }
          
        }
    }
}
