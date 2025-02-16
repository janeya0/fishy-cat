using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerArrow : MonoBehaviour
{
    public GameObject spawnObject;
    public GameObject spawnPoint;
    public GameObject temp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void MoveToBack()
    {
        Destroy(temp);
    }

    // Update is called once per frame
    void Update()
    {
        if (Dialogue.doneDialogue)
        {
            Debug.Log("SPAWNING ARROW");
            Dialogue.doneDialogue = false;
            temp = Instantiate(spawnObject, spawnPoint.transform.position, Quaternion.identity);
            Invoke("MoveToBack", 3);
        }
    }
}
