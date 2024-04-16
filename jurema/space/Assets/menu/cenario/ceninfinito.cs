using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ceninfinito : MonoBehaviour
{
    public float velocidade;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        movimentarcenario();
    }
    private void movimentarcenario ()
    {
        Vector2 deslocamento = new Vector2(0, Time . time * velocidade);
        GetComponent<Renderer>().material.mainTextureOffset = deslocamento;
    }
}
