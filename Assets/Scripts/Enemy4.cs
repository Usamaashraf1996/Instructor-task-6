using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Enemy4 : MonoBehaviour
{
    public TextMeshProUGUI sCORE;
    public static int score = 0;
    public Material[] material;
    Renderer rend;
    public float speed;
    private Rigidbody enemy4;
    public GameObject enemy3;
    // Start is called before the first frame update
    void Start()
    {
        enemy4 = GetComponent<Rigidbody>();
        enemy3 = GameObject.Find("Enemy3");
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        sCORE.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDirection = (enemy3.transform.position - transform.position).normalized;
        enemy4.AddForce(lookDirection * speed);
        //enemy4.transform.Translate(lookDirection * speed);
        sCORE.text = "Player4:" + score.ToString();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy3"))
        {
            rend.sharedMaterial = material[0];
            transform.localScale = transform.localScale + new UnityEngine.Vector3(8 * Time.deltaTime, 8 * Time.deltaTime, 8 * Time.deltaTime);
            score += 1;
        }
      

    }
}
