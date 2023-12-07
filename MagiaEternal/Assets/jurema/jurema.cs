using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jurema : MonoBehaviour
{
    [Header("fisica")]
    public float speed, impulse;
    public Rigidbody2D rb;
    bool botaoPressionadod, botaoPressionadoe, morte = false;
    public Transform pe;
    public LayerMask chao;
    private Animator anime;
    public bool tonochao = true;
    [Header("status")]
    public int vida,puloextra = 3;
    public Image hearton, hearton2, heartoff, heartoff2, hearton3, heartoff3;
    public GameObject restart;
    public Text chavetxt;
    private int chave;

    // Start is called before the first frame update
    void Start()
    {
        anime = GetComponent<Animator>();
        chave=0;
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
        if (tonochao == false && Input.GetButtonDown("Jump") && puloextra>0)
        {
            rb.AddForce(new Vector2(rb.velocity.x, impulse), ForceMode2D.Force);
            puloextra = puloextra - 1;
        }
        if(tonochao)
        {
            puloextra = 2;
        }
        if ( Input.GetKey(KeyCode.S ))
        {

            rb.AddForce(new Vector2(rb.velocity.x, -impulse), ForceMode2D.Force);

        }
        restartplayer();
        dano();
        chavetxt.text = chave.ToString();
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
        if (tonochao == false && Input.GetButtonDown("Jump") && puloextra > 0)
        {
            rb.AddForce(new Vector2(rb.velocity.x, impulse), ForceMode2D.Force);
            puloextra = puloextra - 1;
        }
        if (tonochao)
        {
            puloextra = 1;
        }

    }
    public void despulo()
    {
        

            rb.AddForce(new Vector2(rb.velocity.x,- impulse), ForceMode2D.Force);

       
 
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("morte" ) | col.CompareTag("enemy") | col.CompareTag("espinho") == true)
        {
            vida = vida - 1;
            morte = true;
           
        }
        if (col.CompareTag("chave")  == true)
        {
            chave = chave + 1;
            Destroy(col.gameObject);

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
        if (vida == 1)
        {
            hearton2.enabled = true;
            heartoff2.enabled = false;

            hearton.enabled = true;
            heartoff.enabled = false;
        }
        else
        {
            hearton.enabled = false;
            heartoff.enabled = true;
        }
        if (vida == 0)
        {
            Debug.Log("morreu");
          
        }
       
    }
   

}
