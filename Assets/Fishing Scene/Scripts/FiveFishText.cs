using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiveFishText : MonoBehaviour
{
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
        if (GlobalGameManager.Instance.PlayerStats.TotalCoins >= 5)
        {
            Destroy(this.gameObject);
        }
    }
}
