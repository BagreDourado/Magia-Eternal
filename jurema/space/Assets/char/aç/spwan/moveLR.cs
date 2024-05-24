using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveLR : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocidade = 5f; // Velocidade de movimento do objeto
    private bool movendoParaDireita = true; // Variável para controlar a direção do movimento

    void Update()
    {
        // Movimentação para a direita
        if (movendoParaDireita)
        {
            transform.Translate(Vector2.right * velocidade * Time.deltaTime);
        }
        // Movimentação para a esquerda
        else
        {
            transform.Translate(Vector2.left * velocidade * Time.deltaTime);
        }

        // Verifica se o objeto alcançou o limite da tela para mudar a direção
        if (transform.position.x >= 595f) // Mudar 10f para o valor que desejar
        {
            movendoParaDireita = false;
        }
        else if (transform.position.x <= -615f) // Mudar -10f para o valor que desejar
        {
            movendoParaDireita = true;
        }
    }
}
