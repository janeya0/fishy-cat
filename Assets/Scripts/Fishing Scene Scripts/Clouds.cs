using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clouds : MonoBehaviour
{
    private Rigidbody2D rb;
    float newVelX = 0.1f;
    float[] direction = { 0.1f, -0.1f, 0.3f, -0.3f, 0.2f, -0.2f };
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        newVelX = direction[Random.Range(0, 6)];
    }

    // Update is called once per frame
    void Update()
    {
        float currXPos = rb.position.x;
        if (currXPos + newVelX >= 10 || currXPos + newVelX <= -10)
        {
            newVelX *= -1;
        }
        rb.velocity = new Vector2(newVelX, 0);
    }
}
