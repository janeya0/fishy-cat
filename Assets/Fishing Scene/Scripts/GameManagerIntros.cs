using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerIntros : MonoBehaviour
{
    public GameObject[] spawnObjects;
    public GameObject spawnPoint;
    private GameObject temp;

    private void OnEnable()
    {
        StartCoroutine(WaitForGlobalGameManager());
    }

    private IEnumerator WaitForGlobalGameManager()
    {
        while (GlobalGameManager.Instance == null || GlobalGameManager.Instance.PlayerStats == null)
        {
            // wait 1 frame
            yield return null;
        }
        GlobalGameManager.Instance.PlayerStats.OnLevelUp += UpdateCatIntro; 
    }

    void UpdateCatIntro(int level)
    {
        temp = Instantiate(spawnObjects[level - 1 >= 0 ? level - 1 : 0], spawnPoint.transform.position, Quaternion.identity);
        StaticScoreHolder.cat1IntroPlayed = true;
        Invoke("MoveToBack", 3);
    }

    void MoveToBack()
    {
        Destroy(temp);
    }
}
