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


        Rigidbody2D rb2d = other.attachedRigidbody;
        Vector2 vel = rb2d.velocity;
        Vector2 n_force = new Vector2(-1.5f * vel.x, 0);
        rb2d.AddForce(n_force, ForceMode2D.Impulse);

    }


}

