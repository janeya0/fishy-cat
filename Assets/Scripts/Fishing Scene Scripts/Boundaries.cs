using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Vector3 viewPos = transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, -9, 9);
        viewPos.y = Mathf.Clamp(viewPos.y, -5, 1);
        transform.position = viewPos;
    }
}
