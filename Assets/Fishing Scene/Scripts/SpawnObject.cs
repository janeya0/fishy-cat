using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    private Rigidbody2D rb;
    public int[] direction = { -1, 1 };
    public int currDirection;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        var rand = Random.Range(0, 2);
        currDirection = direction[rand];
        Debug.Log(rand);
        Debug.Log("currDirection: " + currDirection);
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(currDirection * Random.Range(0.5f, 3), rb.velocity.y);
        
    }
}
