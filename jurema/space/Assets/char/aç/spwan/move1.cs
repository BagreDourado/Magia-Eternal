using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move1 : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocidade;
    public GameObject player;
    public Animator anim;
    public bool ia = true;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("player");
        anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null && ia == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, velocidade * Time.deltaTime);
        }


    }
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
      ///  if (collision.CompareTag("bala") == true)
      //  {
            //anim.SetTrigger("dead");
            //ia = false;
        //    Debug.Log("a");
         //   Destroy(gameObject,0.1f);
       //     // Destroy(collision.gameObject);
      //  }
   // }

}
