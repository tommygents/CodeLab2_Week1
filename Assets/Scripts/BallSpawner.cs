using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{

    public Sprite[] ballSprites;
    private float spawnRangeX = 5;
    private float spawnRangeY = 5;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("spawnBalls",1);
    }

    // Update is called once per frame
    void Update()
    {
        
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

}
