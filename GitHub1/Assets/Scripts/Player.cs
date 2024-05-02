using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{



    private  Rigidbody body;
    public float horizontal, speed = 15, vertical;
    // Start is called before the first frame update
    void Start()
    {
        
        body = GetComponent<Rigidbody>();


    }

    // Update is called once per frame
    void Update()
    {

        horizontal = Input.GetAxisRaw("Horizontal");
        body.velocity = new Vector3(body.velocity.x, 0, speed * horizontal);

        vertical = Input.GetAxisRaw("Vertical");
        body.velocity = new Vector3(speed * vertical, 0, body.velocity.z);

      


    }
}
