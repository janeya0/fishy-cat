using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondSpawnObjectScriptRightSide : MonoBehaviour
{
    private Rigidbody2D rb;
    public int[] direction = { -1, 1 };
    public float timer = 0;
    public float newVelX = 1;
    public float newVelY = 0;
    public float timeBetweenDirectionSwitch = 3;
    public float[] rangeOfSpeeds = { -1, -0.9f, -0.7f, -0.5f, -0.4f, -0.3f, -0.2f, -0.1f, 0, 0.1f, 0.2f, 0.3f, 0.4f, 0.5f, 0.7f, 0.9f, 1 };
    public int ranIdxX = 10;
    public int ranIdxY = 8;
    // x bounds: -10, 10
    // y bounds: -4, 2
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        newVelX = -1;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > timeBetweenDirectionSwitch)
        {
            timer = 0;
            ranIdxX = Random.Range(0, rangeOfSpeeds.Length);
            ranIdxY = Random.Range(0, rangeOfSpeeds.Length);
            newVelX = rangeOfSpeeds[ranIdxX];
            newVelY = rangeOfSpeeds[ranIdxY];
        }
        float newYPos = rb.position.y + newVelY;

        // out of bounds: y
        if (newYPos > 1)
        {
            newVelY *= -1;
        }
        rb.velocity = new Vector3(newVelX, newVelY);
        if (rb.position.x < -15 || rb.position.x > 15 || rb.position.y < -7)
        {
            Destroy(gameObject);
        }

    }

    private void OnCollisionEnter2D(Collision2D col2d)
    {
        if (col2d.collider.name == "fish1" || col2d.collider.name == "fish2" || col2d.collider.name == "fish3" || col2d.collider.name == "fish4")
        {
            Physics2D.IgnoreCollision(col2d.collider, col2d.otherCollider);
        }
    }
}
