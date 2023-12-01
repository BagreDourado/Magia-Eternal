using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogue : MonoBehaviour
{
    public Sprite profile;
    public string txt;
    public string profiletxt;
    private dialoguecontrol dc;
    public LayerMask player;
    public float raio;


    // Start is called before the first frame update
   private void Start()
    {
        dc = FindFirstObjectByType<dialoguecontrol>();
    }
    public  void interaçao()
    {
        Collider2D hit = Physics2D.OverlapCircle(transform.position, raio, player);
        if (hit != null)
        {
            dc.speech(profile, txt, profiletxt);
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        interaçao();
    }
}
