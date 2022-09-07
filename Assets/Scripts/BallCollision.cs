using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour
{

    public Rigidbody2D rb;
    public float speed = 40f;
    public Vector2 NewForce;

    private float leftBound = -10;
    private float rightBound = 10;
    private float upperBound = 10;
    private float lowerBound = -10;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
     if (transform.position.x > rightBound)
        {
            Destroy(gameObject);
        }
    }

    public void launch() 
        {
        NewForce = new Vector2(speed, 0);
        rb.AddForce(NewForce, ForceMode2D.Impulse);
}

       
}
