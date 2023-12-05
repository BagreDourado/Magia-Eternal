using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platleft : MonoBehaviour
{
    public float speed = 2.0f;  // Velocidade de movimentação
    public bool on = true;
    public Rigidbody2D plat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (on == true)
        {

            plat.transform.Translate(Vector2.left * (-speed) * Time.deltaTime);
        }
        else if (on == false)
        {

            plat.transform.Translate(Vector2.left * (speed) * Time.deltaTime);
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("barreira") == true)
        {

            on = true;
          
        }
        if (col.CompareTag("barreira2") == true)
        {

            on = false;
           
        }
    }
}
