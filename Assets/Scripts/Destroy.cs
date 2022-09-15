using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour

{
    public float lowerBounds = -2;
  

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <lowerBounds) { 
        Destroy(gameObject);
           
            Debug.Log("work");
        }
    }
}
