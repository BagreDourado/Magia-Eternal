using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jurema : MonoBehaviour
{
    public int vida = 3;
    public float speed , impulse;
    public Rigidbody2D rb;
    bool botaoPressionadod, botaoPressionadoe,morte = false;
   public bool tonochao = true;
    public Transform pe;
    public LayerMask chao;
    private Animator anime;
    public GameObject restart;
    public Image hearton,hearton2, heartoff, heartoff2;
    
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
        restartplayer();

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
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("morte")==true)
        {
            vida = vida - 1;
            morte = true;
            if(vida==0)
            {
                Debug.Log("morreu");
            }
        }
        
    }
    public void restartplayer ()
    {
        if(morte==true)
        {
            rb.transform.position = new Vector2(restart.transform.position.x, restart.transform.position.y);
            morte = false;
        }
    }
    public void dano()
    {
        if(vida==2)
        {
            hearton2.enabled = true;
            heartoff2.enabled = false;
        }
        else
        {
            hearton2.enabled = false;
            heartoff2.enabled = true;
        }
    }
   

}
