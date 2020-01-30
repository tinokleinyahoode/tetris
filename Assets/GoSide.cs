using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoSide : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown (KeyCode.RightArrow)){
            Vector3 pos = transform.position;
            pos.x +=  1;
            transform.position = pos;   
        } 
        if (Input.GetKeyDown (KeyCode.LeftArrow)){
            Vector3 pos = transform.position;
            pos.x -=  1;
            transform.position = pos;
        } 
    }
}
