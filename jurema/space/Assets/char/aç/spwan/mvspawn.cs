
using System.Collections.ObjectModel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mvspawn : MonoBehaviour
{
  

   
    public Transform currentTarget;
    public Transform targeta;
    public Transform targetb;
    private bool flipX;
    public float speed;
   
     void Start()
     {
          currentTarget = targeta ;
     }
    void Update()
    {
        if(currentTarget == targeta && transform.position == targeta.position)
        {
              currentTarget = targetb ;
        }
        if(currentTarget == targetb && transform.position == targetb.position)
        {
              currentTarget = targeta ;
        }
        
        transform.position = Vector2.MoveTowards( transform.position,currentTarget.position, speed* Time.deltaTime);
        if (transform.position.y > transform.position.y)
        {  
            flipX=false;

            
       }
        else
        {
         flipX=true;
       }
   
    }
}
