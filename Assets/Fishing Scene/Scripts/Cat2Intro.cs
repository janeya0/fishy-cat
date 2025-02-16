using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat2Intro : MonoBehaviour
{
    public Animator anim;
    public float timer;
    //public Rigidbody2D rb;
    public bool cat2IntroPlayed;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        //rb = GetComponent<Rigidbody2D>();
        cat2IntroPlayed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (GlobalGameManager.Instance.PlayerStats.TotalCoins >= StaticScoreHolder.fishCaughtToBeIntroduced[1] && !cat2IntroPlayed)
        {
            cat2IntroPlayed = true;
            gameObject.SetActive(true);
            Debug.Log("cat 2 introduced!");
            anim.SetBool("playIntro2", true);
        }
    }
}
