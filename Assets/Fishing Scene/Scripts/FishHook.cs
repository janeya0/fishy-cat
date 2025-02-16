using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishHook : MonoBehaviour
{
    public static FishHook HookInstance;
    public Rigidbody2D rb;
    public LogicManager logic;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //float newYPos = rb.position.y + newVelY;
        float dirX = Input.GetAxis("Horizontal");
        float dirY = Input.GetAxis("Vertical");

        rb.velocity = new Vector2(dirX * 5f, dirY * 5f);


    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("COLLISION");
        if (other.gameObject.name.Equals("fish1"))
        {
            Debug.Log("fish");
            GlobalGameManager.Instance.PlayerStats.AddCoins(1);
            // logic.AddScore(1);
        } else if (other.gameObject.name.Equals("fish2"))
        {
            Debug.Log("fish");
            GlobalGameManager.Instance.PlayerStats.AddCoins(2);
            // logic.AddScore(2);
        } else if (other.gameObject.name.Equals("fish3"))
        {
            Debug.Log("fish");
            GlobalGameManager.Instance.PlayerStats.AddCoins(3);
            // logic.AddScore(3);
        }
        else if (other.gameObject.name.Equals("fish4"))
        {
            Debug.Log("fish");
            GlobalGameManager.Instance.PlayerStats.AddCoins(4);
            // logic.AddScore(4);
        }

        Destroy(other.gameObject);

    }
}
