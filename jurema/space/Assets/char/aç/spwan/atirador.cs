using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atirador : MonoBehaviour
{
    public float velocidade = 5f; // Velocidade de movimento do objeto
    public GameObject projetilPrefab; // Prefab do objeto a ser atirado
    public float intervaloDeAtaque = 2f; // Intervalo de tempo entre os ataques
    private float tempoParaProximoAtaque = 0f; // Tempo até o próximo ataque
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time >= tempoParaProximoAtaque)
        {
            Atirar();
            tempoParaProximoAtaque = Time.time + intervaloDeAtaque;
        }
    }

    void Atirar()
    {
        Instantiate(projetilPrefab, transform.position, Quaternion.identity);
    }
}
