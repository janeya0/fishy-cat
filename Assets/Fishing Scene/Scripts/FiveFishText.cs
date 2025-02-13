using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiveFishText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (StaticScoreHolder.newPlayerScore >= 5)
        {
            Destroy(this.gameObject);
        }
    }
}
