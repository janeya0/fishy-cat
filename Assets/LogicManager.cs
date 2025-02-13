using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicManager : MonoBehaviour
{
    public static LogicManager Instance;
    public static int bonus = 0;
    public Text scoreText;

    [ContextMenu("Increase Score")]
    public void AddScore(int amount)
    {
        StaticScoreHolder.newPlayerScore += amount + bonus;
        scoreText.text = StaticScoreHolder.newPlayerScore.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = StaticScoreHolder.newPlayerScore.ToString();
    }
}
