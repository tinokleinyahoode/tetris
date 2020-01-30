using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoDown : MonoBehaviour
{
    public enum BlockType{i, j, l, o, s, t, z};
    public BlockType type; // Welches Teil (I,J, etc.);
    double interval = .5;
    float lastTime;

     bool[,] grid;

     

    // Start is called before the first frame update
    void Start()
    {
        grid  = new bool[20,10];
        for(int x = 0; x < grid.GetLength(0); x++){
            for(int y = 0; y < grid.GetLength(1); y++){
                grid[x,y] = false;
            }
        }

    }

    // Update is called once per frame
    void Update()
    {

        for(int i = 0; i < transform.childCount; i++){
            Transform child = transform.GetChild(i);

            Vector3 pos = child.position;
            // if()
        }

        if(Time.time > lastTime + interval){
            lastTime = Time.time;
            Vector3 pos = transform.position;
            pos.y -=  1;
            transform.position = pos;
        }

        if (Input.GetKey (KeyCode.DownArrow)){
            Vector2 pos = transform.position;
            pos.y -=  1;
            transform.position = pos;
        } 
    }
}


/*
    Grid denken und innerhalb des Grids abfragen ob im jeweiligen codeblock etwas vorhanden ist.
*/
