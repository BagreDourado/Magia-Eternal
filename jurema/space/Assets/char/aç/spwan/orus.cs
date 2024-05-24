using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orus : MonoBehaviour
{
    int vida = 3;
    public GameObject eu;
 
    public Sprite novoSprite;
    public Sprite novoSprite1;// O novo sprite que será aplicado ao objeto ao colidir
    private SpriteRenderer spriteRenderer; // Referência ao componente SpriteRenderer do objeto
    [Header("sound")]
    public AudioClip shoot;
    private AudioSource audi;
    [Header("espolio")]
    public GameObject espolio;
    public GameObject objetoPrefab; // Referência ao prefab

    public float posicaoX = -530; // Coordenada X para instanciar
    public float posicaoY = 268f;  // Coordenada Y para instanciar

   
        void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        audi = GetComponent<AudioSource>();
        eu.SetActive(true);
        Invoke("Dative", 25f);
           
        }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void playsound()
    {
        audi.PlayOneShot(shoot);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Vector3 posicaoInstanciacao = new Vector3(posicaoX, posicaoY, 0f);
        if (collision.CompareTag("bala"))
        {
            playsound();
            vida = vida - 1;
            if(vida==2)
            {
                spriteRenderer.sprite = novoSprite;
            }
            if(vida==1)
            {
                spriteRenderer.sprite = novoSprite1;
            }
         
           
            if (vida==0)
            {
                Instantiate(espolio, posicaoInstanciacao, Quaternion.identity);
                eu.SetActive(false);
            }

        }
    }
     void Dative()
    {
        eu.SetActive(false);
    }

}
