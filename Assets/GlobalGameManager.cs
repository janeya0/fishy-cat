using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalGameManager : MonoBehaviour
{
    public static GlobalGameManager Instance { get; private set; }
    [SerializeField] private PlayerStats playerStats;
    public PlayerStats PlayerStats => playerStats;
    public bool isFTUE = true;

    // Start is called before the first frame update
    void Start()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        } 
        else {
            Destroy(gameObject);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
