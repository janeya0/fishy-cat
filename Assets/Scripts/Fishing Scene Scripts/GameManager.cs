using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] spawnObject;
    public GameObject temp;
    public GameObject[] spawnPoints;
    public float timer;
    public float timeBetweenSpawns;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > timeBetweenSpawns)
        {
            timer = 0;
            int randSpawnPoint = Random.Range(0, 3);
            int randFishType = Random.Range(0, 4);
            GameObject clone = Instantiate(spawnObject[randFishType], spawnPoints[randSpawnPoint].transform.position, Quaternion.identity);

            if (randFishType == 0)
            {
                clone.name = "fish1";
            } else if (randFishType == 1)
            {
                clone.name = "fish2";
            } else if (randFishType == 2)
            {
                clone.name = "fish3";
            } else if (randFishType == 3)
            {
                clone.name = "fish4";
            }
        }
    }
}
