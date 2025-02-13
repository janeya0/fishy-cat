using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RanSpawner : MonoBehaviour
{
    public GameObject fishPrefab;
    public float timer;
    public float timeBetweenSpawns = 3;
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
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-5,5), Random.Range(-3, 2));
            Instantiate(fishPrefab, randomSpawnPosition, Quaternion.identity);
        }

    }
}
