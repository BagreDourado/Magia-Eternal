using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class enemyNT : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player; // Refer�ncia ao transform do jogador
    public float moveSpeed = 5f; // Velocidade de movimento do inimigo

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Verifica se o jogador est� � frente do inimigo
        if (player.position.x > transform.position.x)
        {
            // Move o inimigo para a dire��o do jogador
            rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
        }
        else
        {
            // Move o inimigo na dire��o oposta
            rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
        }
    }
}
