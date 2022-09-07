using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{

    
    public Sprite[] ballSprites;
    private float spawnRangeX = 5;
    private float spawnRangeY = 5;

    private float leftBound = -10;
    private float rightBound = 10;
    private float upperBound = 10;
    private float lowerBound = -10;

    private Camera cam;
    private Vector3 shootpos;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        Invoke("spawnBalls",1);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mouspos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
            shootpos = new Vector3(leftBound, cam.ScreenToWorldPoint(mouspos).y, 0);
            // shootpos = new Vector3(leftBound, 5, 0);
            GameObject projectile = Instantiate(Resources.Load("Prefabs/Circle")) as GameObject;
            
            projectile.transform.position = shootpos;
            SpriteRenderer sp = projectile.GetComponent<SpriteRenderer>();
            sp.sprite = ballSprites[0];
            projectile.GetComponent<BallCollision>().launch();
           // rb.launch();
        }
        
    }

    void spawnBalls()
    {
        foreach (Sprite ball in ballSprites)
        {
            Vector3 spawnpos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY), 0);
            GameObject go = Instantiate(Resources.Load("Prefabs/Circle")) as GameObject;
            go.transform.position = spawnpos;
            SpriteRenderer color = go.GetComponent<SpriteRenderer>();
            color.sprite = ball;

        }
    }

    void shootBall() 
    {
        Vector3 shootpos = new Vector3(Input.mousePosition.x, -5, 0);
    }

}
