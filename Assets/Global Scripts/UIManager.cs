using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set; }
    [SerializeField] private Text TotalCoinsText;
     private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDestroy()
    {
        StopAllCoroutines();
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        GameObject coinsTextObject = GameObject.FindWithTag("TotalCoinsText");
        if (coinsTextObject != null)
        {
            TotalCoinsText = coinsTextObject.GetComponent<Text>();

            if (TotalCoinsText != null)
            {
                UpdateTotalCoinsUI();
            }
        }
    }

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
        UpdateTotalCoinsUI();
        GlobalGameManager.Instance.PlayerStats.OnTotalCoinsChanged += UpdateTotalCoinsUI; 
    }

    private void UpdateTotalCoinsUI()
    {
        if (GlobalGameManager.Instance != null && GlobalGameManager.Instance.PlayerStats != null && TotalCoinsText != null)
        {
            TotalCoinsText.text = GlobalGameManager.Instance.PlayerStats.TotalCoins.ToString();
        }
    }
}
