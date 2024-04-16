using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class enemyNT : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject  eu;
    [Header("move")]
    public Transform player; // Referência ao Transform do jogador
    public float speed = 5.0f;
    public int tt;

    void Start()
    {
        autodestruc();
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            // Direção do inimigo para o jogador
            Vector3 direction = player.position - transform.position;
            direction.Normalize();

            // Movimenta o inimigo em direção ao jogador
            transform.position += direction * speed * Time.deltaTime;
        }
    }
    private void autodestruc()
    {
        Destroy(eu,tt);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("bala"))
        {
            Destroy(eu);
        }
        
    }
}
