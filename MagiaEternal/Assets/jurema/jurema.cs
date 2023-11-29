using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jurema : MonoBehaviour
{

    public float speed;
    public Rigidbody2D rb;
    private bool botaoPressionadod = false;
    private bool botaoPressionadoe = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (botaoPressionadod == true)
        {
            // Chama a função de ação enquanto o botão está pressionado.
            rb.velocity = new Vector2(speed, 0);
        }
        else  if(botaoPressionadoe==true)
        {
            rb.velocity = new Vector2(-speed, 0);
        }
        else
        {
            rb.velocity = new Vector2(0, 0);
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
   

}
