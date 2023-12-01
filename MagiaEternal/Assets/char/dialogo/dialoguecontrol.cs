using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialoguecontrol : MonoBehaviour
{

    [Header("componentes")]
    public GameObject controle;
    public Image profile;
    public Text discurso;
    public Text actor;

    [Header("info")]
    public float velo;

    public void  speech (Sprite p ,string txt , string actorname)
    {
        controle.SetActive(true);
        profile.sprite = p;
        discurso.text = txt;
        actor.text = actorname;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
