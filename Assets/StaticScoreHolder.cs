using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaticScoreHolder : MonoBehaviour
{ 
    public static int newPlayerScore = 0;
    public static int[] fishCaughtToBeIntroduced = { 10, 15, 16, 150, 200, 500, 1000 };
    public static int[] levels = { 50, 100, 150, 300, 500, 1000, 2000 };
    public static int currLevel = 0;
    public Text scoreText;

    // bools for GameManagerIntros (only introducing cat animation once)
    public static bool cat1IntroPlayed = false;
    public static bool cat2IntroPlayed = false;
    public static bool cat3IntroPlayed = false;
    public static bool cat4IntroPlayed = false;
    public static bool cat5IntroPlayed = false;
    public static bool cat6IntroPlayed = false;
    public static bool cat7IntroPlayed = false;

    public static bool introPlayed = false;

    // Start is called before the first frame update
    void Awake()
    {
    }

    void Start() 
    {
        scoreText.text = newPlayerScore.ToString(); 
    }

    // Update is called once per frame
    void Update()
    {
    }
}
