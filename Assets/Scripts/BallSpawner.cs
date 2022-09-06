using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour

    
{
    // Rather than use 'public GameObject[] ballPrefabs;' I want a bunch of different sprites for the same prefab

    public Sprite[] ballSprites;
    private float spawnRangeX = 25;
    private float spawnRangeY = 25;
 

    // Start is called before the first frame update
    void Start()
    {
        // Vector3 spawnpos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY), 0);
        // Instantiate(Resources.Load("Prefabs/Circle"), spawnpos, Resources.Load("Prefabs/Circle").transform.rotation);
        GameObject go = Instantiate(Resources.Load("Prefabs/Circle"),) as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  void SpawnBalls()
    {
   //First I want to spawn four balls, one of each color
        foreach (Sprite ball in ballSprites)
        {
            GameObject go = Instantiate(Resources.Load("Prefabs/Circle")) as GameObject;

        }

        Vector2 spawnpos = new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY));
    } 
}


// What is the relationship between gameObjects and their sprites?