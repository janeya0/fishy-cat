using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatManager : MonoBehaviour
{
    [SerializeField] private GameObject[] cats;

    [SerializeField] private GameObject[] spawnPoints;
    private GameObject temp;

    // Start is called before the first frame update

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

        for (int i = 0; i < GlobalGameManager.Instance.PlayerStats.levelUpThresholds.Count; ++i)
        {
            if (GlobalGameManager.Instance.PlayerStats.TotalCoins >= GlobalGameManager.Instance.PlayerStats.levelUpThresholds[i])
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
