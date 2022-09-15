using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   public TextMeshProUGUI sCORE;
    public static int score = 0;
    public Material[] material;
    Renderer rend;
    public float speed = 10;
    private Rigidbody playerRb;
   
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        sCORE.text = score.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        

        float forwardInput = Input.GetAxis("Vertical");
        playerRb.AddForce(Vector3.forward *forwardInput* speed * Time.deltaTime*4);
        
        //transform.Translate(Vector3.forward *forwardInput* speed * Time.deltaTime);
        float horizontlInput = Input.GetAxis("Horizontal");
        playerRb.AddForce(Vector3.right * horizontlInput * speed * Time.deltaTime*4);
        // transform.Translate(Vector3.right *horizontlInput* speed * Time.deltaTime);
        sCORE.text = "Player1:"+score.ToString();

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy2")) {
            rend.sharedMaterial = material[0];
            transform.localScale = transform.localScale + new UnityEngine.Vector3(8 * Time.deltaTime, 8 * Time.deltaTime, 8 * Time.deltaTime);
            score += 1;
        }
    }
}
