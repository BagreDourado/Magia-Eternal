using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruiçao : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject eu;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("bala"))
        {
            Destroy(eu);
        }
    }
}
