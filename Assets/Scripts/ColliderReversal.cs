using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderReversal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {


        RigidBody2D rb = other.GetComponent<RigidBody2D>();
        Vector2 vel = rb.velocity;
        Vector2 n_vel = 

    }


}

