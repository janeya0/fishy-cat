using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Arrow : MonoBehaviour
{
    public Image arrow;
    // Start is called before the first frame update
    void Start()
    {
        arrow.enabled = false;
        //rb = GetComponent<Rigidbody2D>();
        //origPos = rb.position.x;
        //rb.position = new Vector2(-10000, rb.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        if (Dialogue.doneDialogue)
        {
            Dialogue.doneDialogue = false;
            arrow.enabled = true;
            //rb.position = new Vector2(origPos, rb.position.y);
        }
    }
}
