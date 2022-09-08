using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingCollider : MonoBehaviour
{
    public Rigidbody2D rb;
    private Collider rc;
    private GameObject spawner;
    // Start is called before the first frame update
    void Start()
    {
        spawner = GameObject.Find("Spawner");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
       
        if (other.tag == "Target")
        {
            Debug.Log("Target Hit");

            spawner.GetComponent<BallSpawner>().score++;
            spawner.GetComponent<BallSpawner>().reset = true;
            
            
            // wipe the board
        }
        // Destroy(other.gameObject);

    }

}
