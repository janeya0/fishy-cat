using System;
using System.Collections.Generic;
using UnityEngine;


public class FishManager : MonoBehaviour
{
    private const int FISH_DIRECTIONS = 2;
    [SerializeField] private GameObject[] spawnObjectsLeftSide;
    [SerializeField] private GameObject[] spawnPointsLeftSide;
    [SerializeField] private GameObject[] spawnObjectsRightSide;
    [SerializeField] private GameObject[] spawnPointsRightSide;
    [SerializeField] private float timeBetweenSpawns;
    private float timer = 0;
    private Dictionary<int, String> fishTypes = new Dictionary<int, String>()
    {
        { 0, "fish1"}, 
        { 1, "fish2" }, 
        { 2, "fish3" }, 
        { 3, "fish4" }
    };

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timeBetweenSpawns)
        {
            timer = 0;
            int randFishType = UnityEngine.Random.Range(0, fishTypes.Count);
            int randDirection = UnityEngine.Random.Range(0, FISH_DIRECTIONS);

            if (randDirection == 0)
            {
                int randSpawnPoint = UnityEngine.Random.Range(0, spawnPointsRightSide.Length);
                GameObject clone = Instantiate(spawnObjectsLeftSide[randFishType], spawnPointsLeftSide[randSpawnPoint].transform.position, Quaternion.identity);
                clone.name = fishTypes[randFishType];
            }
            else
            {
                int randSpawnPoint = UnityEngine.Random.Range(0, spawnPointsRightSide.Length);
                GameObject clone = Instantiate(spawnObjectsRightSide[randFishType], spawnPointsRightSide[randSpawnPoint].transform.position, Quaternion.identity);
                clone.name = fishTypes[randFishType];
            }
            
        }
    }
}
