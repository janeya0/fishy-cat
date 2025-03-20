using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat1Intro : MonoBehaviour
{
    public Animator anim;
    public float timer;
    public Rigidbody2D rb;
    public bool cat1IntroPlayed;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        cat1IntroPlayed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (GlobalGameManager.Instance.PlayerStats.TotalCoins >= GlobalGameManager.Instance.PlayerStats.levelUpThresholds[1] && !cat1IntroPlayed)
        {
            cat1IntroPlayed = true;
            anim.SetBool("playIntro", true);
        }
    }
}
