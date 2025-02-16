using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalGameManager : MonoBehaviour
{
    public static GlobalGameManager Instance { get; private set; }
    [SerializeField] private PlayerStats playerStats;
    public PlayerStats PlayerStats => playerStats;
    // public Text TotalCoinsText;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");
        if (Instance == null)
        {
            Debug.Log("instance == null");
            Instance = this;
            DontDestroyOnLoad(gameObject);
        } 
        else {
            Debug.Log("instance != null");
            Destroy(gameObject);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
