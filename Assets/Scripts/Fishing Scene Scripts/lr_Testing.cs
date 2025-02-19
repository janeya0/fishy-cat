using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lr_Testing : MonoBehaviour
{
    [SerializeField] private Transform[] points;
    [SerializeField] private Lr line;

    // Start is called before the first frame update
    void Start()
    {
        line.SetUpLine(points);
    }
}
