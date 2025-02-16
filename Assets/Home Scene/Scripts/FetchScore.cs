using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FetchScore : MonoBehaviour
{
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = GlobalGameManager.Instance.PlayerStats.TotalCoins.ToString(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
