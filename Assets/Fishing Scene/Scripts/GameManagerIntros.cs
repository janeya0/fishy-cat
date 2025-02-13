using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerIntros : MonoBehaviour
{
    public GameObject[] spawnObjects;
    public GameObject spawnPoint;
    private GameObject temp;
    private GameObject temp2;
    private GameObject temp3;
    private GameObject temp4;
    private GameObject temp5;
    private GameObject temp6;
    private GameObject temp7;

    // Start is called before the first frame update
    void Start()
    {
    }

    void MoveToBack()
    {
        //Debug.Log("IN move to back");
        Destroy(temp);
    }

    void MoveToBack2()
    {
        //Debug.Log("IN move to back");
        Destroy(temp2);
    }

    void MoveToBack3()
    {
        //Debug.Log("IN move to back");
        Destroy(temp3);
    }

    void MoveToBack4()
    {
        //Debug.Log("IN move to back");
        Destroy(temp4);
    }

    void MoveToBack5()
    {
        //Debug.Log("IN move to back");
        Destroy(temp5);
    }

    void MoveToBack6()
    {
        //Debug.Log("IN move to back");
        Destroy(temp6);
    }

    void MoveToBack7()
    {
        //Debug.Log("IN move to back");
        Destroy(temp7);
    }

    // Update is called once per frame
    void Update()
    {
        if (StaticScoreHolder.newPlayerScore >= StaticScoreHolder.fishCaughtToBeIntroduced[0] && !StaticScoreHolder.cat1IntroPlayed)
        {
            temp = Instantiate(spawnObjects[0], spawnPoint.transform.position, Quaternion.identity);
            StaticScoreHolder.cat1IntroPlayed = true;
            Invoke("MoveToBack", 3);
        }
        if (StaticScoreHolder.newPlayerScore >= StaticScoreHolder.fishCaughtToBeIntroduced[1] && !StaticScoreHolder.cat2IntroPlayed)
        {
            temp2 = Instantiate(spawnObjects[1], spawnPoint.transform.position, Quaternion.identity);
            StaticScoreHolder.cat2IntroPlayed = true;
            Invoke("MoveToBack2", 3);
        }

        if (StaticScoreHolder.newPlayerScore >= StaticScoreHolder.fishCaughtToBeIntroduced[2] && !StaticScoreHolder.cat3IntroPlayed)
        {
            temp3 = Instantiate(spawnObjects[2], spawnPoint.transform.position, Quaternion.identity);
            StaticScoreHolder.cat3IntroPlayed = true;
            Invoke("MoveToBack3", 3);
        }

        if (StaticScoreHolder.newPlayerScore >= StaticScoreHolder.fishCaughtToBeIntroduced[3] && !StaticScoreHolder.cat4IntroPlayed)
        {
            temp4 = Instantiate(spawnObjects[3], spawnPoint.transform.position, Quaternion.identity);
            StaticScoreHolder.cat4IntroPlayed = true;
            Invoke("MoveToBack4", 3);
        }

        if (StaticScoreHolder.newPlayerScore >= StaticScoreHolder.fishCaughtToBeIntroduced[4] && !StaticScoreHolder.cat5IntroPlayed)
        {
            temp5 = Instantiate(spawnObjects[4], spawnPoint.transform.position, Quaternion.identity);
            StaticScoreHolder.cat5IntroPlayed = true;
            Invoke("MoveToBack5", 3);
        }

        if (StaticScoreHolder.newPlayerScore >= StaticScoreHolder.fishCaughtToBeIntroduced[5] && !StaticScoreHolder.cat6IntroPlayed)
        {
            temp6 = Instantiate(spawnObjects[5], spawnPoint.transform.position, Quaternion.identity);
            StaticScoreHolder.cat6IntroPlayed = true;
            Invoke("MoveToBack6", 3);
        }

        if (StaticScoreHolder.newPlayerScore >= StaticScoreHolder.fishCaughtToBeIntroduced[6] && !StaticScoreHolder.cat7IntroPlayed)
        {
            temp7 = Instantiate(spawnObjects[6], spawnPoint.transform.position, Quaternion.identity);
            StaticScoreHolder.cat7IntroPlayed = true;
            Invoke("MoveToBack7", 3);
        }

    }
}
