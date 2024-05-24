using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.AI;
public class player : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed ;
    [Header("action")]
    public GameObject bala;
    public Transform arma;
    public bool tiro;
    public float speedtiro;
    public bool flipy;
    public int tt ;
    public float cadencia;
    private float ac=1;
    [Header("sound")]
    public AudioClip shoot;
    private AudioSource audi;
    [Header("vida")]
    public  int  vida;
    public int vidamaxima=100;
    public Image vida1;
    public Image vida2;
    public Image vida3;
    public Image vida4;
    public Image vida5;
    [Header("score")]
    public int score = 0; 
    public Text scoreText;

    void Start()
    {
        vida = vidamaxima;
       
        audi = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.localEulerAngles = new Vector3(0, 0, 0);
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical") ,0) ;
        transform.position = transform.position + movement  *moveSpeed * Time.deltaTime;
        ac += Time.deltaTime;
        if(Input.GetKeyDown(KeyCode.Space) &&  ac>= cadencia)
        {
            playsound();
            Atirar();
            ac = 0;
           
        }

       
    }
    public void Atirar()
    {
       
        GameObject bullet = Instantiate(bala, arma.position, arma.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.velocity = arma.up * speedtiro;
        Destroy(bullet, tt);
     
            
    }
    public void playsound()
    {
        audi.PlayOneShot(shoot);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("enemy"))
        {

            vida = vida - 10;
            if(vida==90)
            {
                vida2.enabled = true;
                vida1.enabled = false;
            }
            if (vida == 70)
            {
                vida3.enabled = true;
                vida2.enabled = false;
            }
            if (vida == 50)
            {
                vida4.enabled = true;
                vida3.enabled = false;
            }
            if (vida == 20)
            {
                vida5.enabled = true;
                vida4.enabled = false;
            }
            if(vida==0)
            {
                SceneManager.LoadScene(1);
            }
          
        }
        if (collision.CompareTag("coin"))
        {
            score = score + 1; 
            UpdateScoreText(); 
            Destroy(collision.gameObject); 
        }
    }
    void UpdateScoreText()
    {
        
        scoreText.text =  score.ToString();
    }
}
