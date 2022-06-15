// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
     public Rigidbody rb;
     public float ForwordForce = 2000f;
    // // Start is called before the first frame update
    // void Start()
    // {

    //     rb.AddForce(0,0,800);
    // }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,00,ForwordForce* Time.deltaTime );
        if( Input.GetKey("a") )
         {
            rb.AddForce( - 600* Time.deltaTime,0,0);
         }
        if( Input.GetKey("d") )
          {
            rb.AddForce(1000* Time.deltaTime,0,0);
          }
    }

    
}
