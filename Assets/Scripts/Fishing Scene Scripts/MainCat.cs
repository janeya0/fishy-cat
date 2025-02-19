using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCat : MonoBehaviour
{
    [SerializeField] private Vector3 _rotation;
    public float timer = 0;
    public float timeBetweenDirectionSwitch = 10;
    public float direction = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;
        if (timer >= 5)
        {
            timer = 0;
            direction *= -1f;

        }
        transform.Rotate(Vector3.forward * direction * Time.deltaTime);
    }
}
