using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePR : MonoBehaviour
{
    // Start is called before the first frame update
  
        public float velocidadeDescida = 2f; // Velocidade de movimento para baixo

        void Update()
        {
            // Movimenta o objeto para baixo
            transform.Translate(Vector2.down * velocidadeDescida * Time.deltaTime);

            // Se o objeto estiver fora da tela, ele é destruído
           
                Destroy(gameObject,10);
           
        }

    
}
