using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat3Intro : MonoBehaviour
{
    public Animator anim;
    public float timer;
    public Rigidbody2D rb;
    public bool cat3IntroPlayed;
    public int index;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        cat3IntroPlayed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (StaticScoreHolder.newPlayerScore >=
            StaticScoreHolder.fishCaughtToBeIntroduced[index] &&
            !cat3IntroPlayed)
        {
            cat3IntroPlayed = true;
            anim.SetBool("playIntro", true);
        }
    }
}
