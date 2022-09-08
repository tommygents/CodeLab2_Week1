using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{

    
    public Sprite[] ballSprites;
    public GameObject[] ballArray;
    public GameObject goRing;
    public Sprite[] ringSprite;
    private float spawnRangeX = 2.5f;
    private float spawnRangeY = 2.5f;

    private float leftBound = -7;
    private float rightBound = 7;
    private float upperBound = 7;
    private float lowerBound = -7;

    private Camera cam;
    private Vector3 shootpos;

    public List<GameObject> envInst = new List<GameObject>();
    public bool reset;

    public int score = 0;
    private int attempts = 0;
    private int lives = 3;
    

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        reset = false;
        spawnBalls();
        spawnRing();


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (lives == 0)
            {
                resetBoard();
            }

            else
            {
                Vector3 mouspos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
                shootpos = new Vector3(leftBound, cam.ScreenToWorldPoint(mouspos).y, 0);
                GameObject projectile = Instantiate(Resources.Load("Prefabs/Ball")) as GameObject;

                projectile.transform.position = shootpos;
                SpriteRenderer sp = projectile.GetComponent<SpriteRenderer>();
                sp.sprite = ballSprites[0];
                projectile.GetComponent<BallCollision>().launch();
                envInst.Add(projectile);

                if (lives == 1)
                {
                    lives--;
                    Debug.Log("You're out of shots! Click to reset.");
                }

                else
                {
                    lives--;
                    Debug.Log("You have " + lives + " shots remaining.");
                }
            }
        }

        if (reset)
        {
            resetBoard();
            Debug.Log("Score: " + score + " successes out of " + attempts + " attempts");
            reset = false;
        }
        
    }

    void spawnBalls()
    {
        foreach (GameObject ball in ballArray)
        {
            Vector3 spawnpos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY), 0);
            GameObject go = Instantiate(ball);
            go.transform.position = spawnpos;
            envInst.Add(go);

        }
    }

   /* void initialize()
    {
        foreach (GameObject ball in ballArray)
        {
            Vector3 spawnpos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY), 0);
            GameObject go = Instantiate() as GameObject;
            go.transform.position = spawnpos;
            SpriteRenderer color = go.GetComponent<SpriteRenderer>();
            color.sprite = ball;

        }
    } */

    void spawnRing()
    {
        Vector3 spawnpos = new Vector3(rightBound - 2, Random.Range(-spawnRangeY, spawnRangeY), 0);
        GameObject rgo = Instantiate(Resources.Load("Prefabs/Ring")) as GameObject;
        rgo.transform.position = spawnpos;
       SpriteRenderer ring = rgo.GetComponent<SpriteRenderer>();
        ring.sprite = ringSprite[0];
        goRing = rgo;

    }


    public void resetBoard()
    {
        foreach (GameObject go in envInst)
        {
            Destroy(go);
        }
        /*  for (int i = 0; i < envInst.Count; i++)
        {
            GameObject go = envInst[i];
            if (envInst[i].tag == "Cue")
            {
                Destroy(envInst[i]);
                envInst.Insert(i,null);
                
            }
            else
            {
                Vector3 spawnpos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY), 0);
                go.transform.position = spawnpos;
                // go.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            }

        } */
        envInst = envInst = new List<GameObject>();
        spawnBalls();
        Vector3 rspawnpos = new Vector3(rightBound - 2, Random.Range(-spawnRangeY, spawnRangeY), 0);
        goRing.transform.position = rspawnpos;
        
        attempts++;
        lives = 3;


    }

    public void fireCue()
    {

    }
}
