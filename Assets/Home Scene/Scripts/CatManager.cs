using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatManager : MonoBehaviour
{
    [SerializeField] private GameObject[] cats;

    [SerializeField] private GameObject[] spawnPoints;
    private GameObject temp;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < StaticScoreHolder.fishCaughtToBeIntroduced.Length; ++i)
        {
            if (StaticScoreHolder.newPlayerScore >= StaticScoreHolder.fishCaughtToBeIntroduced[i])
            {
                temp = Instantiate(cats[i], spawnPoints[i].transform.position, Quaternion.identity);
                temp.name = "Cat";
            } else
            {
                break;
            }
        }
    }
}
