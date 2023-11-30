using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jurema : MonoBehaviour
{

    public float speed;
    public float impulse;
    public Rigidbody2D rb;
    private bool botaoPressionadod = false;
    private bool botaoPressionadoe = false;
   public bool tonochao = true;
    public Transform pe;
    public LayerMask chao;
  
    private Animator anime;
    // Start is called before the first frame update
    void Start()
    {
        anime = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (botaoPressionadod == true | Input.GetKey(KeyCode.D))
        {
            // Chama a função de ação enquanto o botão está pressionado.
            rb.velocity = new Vector2(speed, rb.velocity.y);
            anime.SetBool("direita", true);
            
        }
        else  if(botaoPressionadoe==true | Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
            anime.SetBool("esquerda", true);

        }
        else
        {
            anime.SetBool("direita", false);
            rb.velocity = new Vector2(0, rb.velocity.y);
            anime.SetBool("esquerda", false);
        }
        tonochao = Physics2D.OverlapCircle(pe.position, 0.2f, chao);


        if (tonochao == true && Input.GetButtonDown("Jump"))
        {




            rb.AddForce(new Vector2(rb.velocity.x, impulse), ForceMode2D.Force);

        }

    }
    public void  parou()
    {
        botaoPressionadod = false;
        botaoPressionadoe = false;
    }
    public void andardireita()
    {
        botaoPressionadod = true;
     
        
    }
    public void andaresquerda()
    {
        botaoPressionadoe = true;
    }
    public void pulo ()
    {
        
       if(tonochao == true | Input.GetKey(KeyCode.W))
        {
           



            rb.AddForce(new Vector2(rb.velocity.x, impulse), ForceMode2D.Force);
           
        }
        
           
      
        
    }

   

}
