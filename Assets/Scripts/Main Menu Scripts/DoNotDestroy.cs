using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoNotDestroy : MonoBehaviour
{
    private void Awake()
    {
        GameObject[] musicObj = GameObject.FindGameObjectsWithTag("StartAudio");
        Scene scene = SceneManager.GetActiveScene();

        if (musicObj.Length > 1) //  || (scene.name != "Instructions" && scene.name != "Menu")
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
