using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sp : MonoBehaviour
{
    public GameObject enemy;
    public float nextspawn;
    public float spawnrate;
    public float timelevel;
    public float tm = 10;

    void Update()
    {
        // Incrementa o tempo decorrido
       
        

            if (Time.time > nextspawn)
            {
                nextspawn = Time.time + spawnrate;
                Instantiate(enemy, transform.position, enemy.transform.rotation);




            }
        
    }



}
