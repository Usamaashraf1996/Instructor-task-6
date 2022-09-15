using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    public Material[] material;
    Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        //rend.sharedMaterial = material[0];
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy1"))
        {
            rend.sharedMaterial = material[1];
        }
        else if (collision.gameObject.CompareTag("Enemy2")) { 
        rend.sharedMaterial = material[2];
        }
        else if (collision.gameObject.CompareTag("Enemy3"))
        {
            rend.sharedMaterial = material[3];
        }
        else if (collision.gameObject.CompareTag("Enemy4"))
        {
            rend.sharedMaterial = material[4];
        }
    }
}
