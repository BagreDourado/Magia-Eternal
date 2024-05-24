using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class enemyNT : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player; // Referência ao transform do jogador
    public float moveSpeed = 5f; // Velocidade de movimento do inimigo

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Verifica se o jogador está à frente do inimigo
        if (player.position.x > transform.position.x)
        {
            // Move o inimigo para a direção do jogador
            rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
        }
        else
        {
            // Move o inimigo na direção oposta
            rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
        }
    }
}
