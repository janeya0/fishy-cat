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
        cat2IntroPlayed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (GlobalGameManager.Instance.PlayerStats.TotalCoins >= GlobalGameManager.Instance.PlayerStats.levelUpThresholds[1] && !cat2IntroPlayed)
        {
            cat2IntroPlayed = true;
            gameObject.SetActive(true);
            anim.SetBool("playIntro2", true);
        }
    }
}
