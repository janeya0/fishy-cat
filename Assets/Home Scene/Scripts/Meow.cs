using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meow : MonoBehaviour
{
    public AudioSource mySounds;
    public AudioClip meow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseOver()
    {
        //If your mouse hovers over the GameObject with the script attached, output this message
        if (Input.GetMouseButtonDown(0)) {
        Debug.Log("Mouse is ver GameObject");
            // Whatever you want it to do.
            //GetComponent<AudioSource>().Play();
            mySounds.PlayOneShot(meow);
        }
    }
}
