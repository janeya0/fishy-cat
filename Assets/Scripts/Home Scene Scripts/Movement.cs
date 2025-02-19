using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public float direction;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(speed * direction, 0);
    }

    private void OnCollisionEnter2D(Collision2D col2d)
    {
        if (col2d.collider.name == "Cat")
        {
            Physics2D.IgnoreCollision(col2d.collider, col2d.otherCollider);
        }
        else
        {
            anim.SetBool("left", !anim.GetBool("left"));
            direction *= -1;
        }
    }
}
