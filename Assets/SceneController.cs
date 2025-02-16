using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public enum Scene
    {
        Menu,
        Home,
        Fishing,
        Instructions,
        Intro
    }

    public void LoadHomeScene()
    {
        GameObject[] musicObj = GameObject.FindGameObjectsWithTag("StartAudio");
        for (int i = 0; i < musicObj.Length; ++i)
        {
            Destroy(musicObj[i]);
        }
        SceneManager.LoadScene(Scene.Home.ToString());
    }

    public void LoadFishingScene() 
    {
        SceneManager.LoadScene(Scene.Fishing.ToString());
    }

    public void LoadMenuScene() 
    {
        SceneManager.LoadScene(Scene.Menu.ToString());
    }
    
    public void LoadFTUEScene()
    {
        GameObject[] musicObj = GameObject.FindGameObjectsWithTag("StartAudio");
        for (int i = 0; i < musicObj.Length; ++i)
        {
            Destroy(musicObj[i]);
        }

        if (!StaticScoreHolder.introPlayed)
        {
            StaticScoreHolder.introPlayed = true;
            SceneManager.LoadScene(Scene.Intro.ToString());
        } else
        {
            SceneManager.LoadScene(Scene.Home.ToString());
        }
    }

    public void LoadInstructionsPage() 
    {
        SceneManager.LoadScene(Scene.Instructions.ToString());
    }


}
