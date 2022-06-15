using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
     public Rigidbody rb;
    // // Start is called before the first frame update
    void Start()
    {

        rb.AddForce(0,0,800);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0,2000* Time.deltaTime );
    }
}
