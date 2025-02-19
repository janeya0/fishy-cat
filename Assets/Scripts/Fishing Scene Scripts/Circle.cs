using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    //[SerializeField] private Vector3 _rotation;
    public float timer = 0;
    //public float timeBetweenDirectionSwitch = 10;
    public float direction = 0.000000001f;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;
        if (timer >= 0.1)
        {
            timer = 0;
            direction *= -1f;

        }
        rb.velocity = new Vector2(direction * -1, direction);
        //transform.Rotate(Vector3.forward * direction * Time.deltaTime);
    }
}
