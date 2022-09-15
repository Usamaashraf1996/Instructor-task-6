using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public TextMeshProUGUI sCORE;
    public static int score = 0;
    public Material[] material;
    Renderer rend;
    public float speed;
    private Rigidbody enemyRb;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
        rend = GetComponent<Renderer>();
        rend.enabled = true;
      //  sCORE.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDirection=(player.transform.position-transform.position).normalized;
        enemyRb.AddForce(lookDirection*speed);
        //enemyRb.transform.Translate(lookDirection * speed);
       sCORE.text = "Player3:"+score.ToString();

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            rend.sharedMaterial = material[0];
            transform.localScale = transform.localScale + new UnityEngine.Vector3(8 * Time.deltaTime, 8 * Time.deltaTime, 8 * Time.deltaTime);
            score += 1;
        }
       
        
    }
}
