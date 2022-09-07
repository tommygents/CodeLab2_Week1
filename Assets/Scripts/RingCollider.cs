using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingCollider : MonoBehaviour
{
    public Rigidbody2D rb;
    private Collider rc;

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
        Debug.Log("Destroy Collision");
        if (other.name == "Target")
        {
            Debug.Log("Target Hit");
            // increment the score
            // wipe the board
            // re-instantiate everything
        }
        Destroy(other.gameObject);
    }

}
