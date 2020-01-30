using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createBlock : MonoBehaviour
{

    public GameObject i;
    public GameObject j;   
    public GameObject l;    
    public GameObject o;   
    public GameObject s;   
    public GameObject t;    
    public GameObject z;
    public GameObject[] go;

    float interval = .5f;
    float lastTime;
    GameObject instance;

    private void create(){
        go = new GameObject[]{i,j,l,o,s,t,z};
        int r = UnityEngine.Random.Range(0, go.Length);
        instance = GameObject.Instantiate(go[r]);
        instance.transform.position = Camera.main.transform.position + Vector3.forward * 10 + Vector3.up * 2;
    }
    private void createUpdate(){
        if(Time.time > lastTime + interval){
            lastTime = Time.time;
            go = new GameObject[]{i,j,l,o,s,t,z};

            int r = UnityEngine.Random.Range(0, go.Length);
        
            instance = GameObject.Instantiate(go[r]);
            // instance.transform.position = new Vector3(3, 10, 0);

            instance.transform.position = Camera.main.transform.position + Vector3.forward * 10;
        }
    }

    void Start(){
        create(); 
    }
    
    // Update is called once per frame
    void Update()
    {
        // createUpdate();
    }
}
