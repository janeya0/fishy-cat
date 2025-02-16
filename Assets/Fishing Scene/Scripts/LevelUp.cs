using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class LevelUp : MonoBehaviour
{
    public Button levelUpBtn;
    public TextMeshProUGUI levelUpBtnText;    
    public TextMeshProUGUI currLevelText;    
    public TextMeshProUGUI levelUpExplanation;    
    public Image lockImage;

    // Start is called before the first frame update
    void Start()
    {
        currLevelText.text = (StaticScoreHolder.currLevel + 1).ToString();
        levelUpExplanation.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (GlobalGameManager.Instance.PlayerStats.TotalCoins < StaticScoreHolder.levels[StaticScoreHolder.currLevel])
        {
            levelUpBtn.interactable = false;
            levelUpBtnText.color = Color.grey;
            lockImage.enabled = true;
        } else {
            levelUpBtn.interactable = true;
            levelUpBtnText.color = Color.black;
            lockImage.enabled = false;
        }
    }

    public void ExecuteLevelUp()
    {
        if (GlobalGameManager.Instance.PlayerStats.TotalCoins >= StaticScoreHolder.levels[StaticScoreHolder.currLevel]) 
        {
            if (StaticScoreHolder.currLevel + 1 < StaticScoreHolder.levels.Length) 
            {
                LogicManager.bonus += 1;
                StaticScoreHolder.currLevel += 1;
                currLevelText.text = (StaticScoreHolder.currLevel + 1).ToString();
            }

            UpdateLevelUpExplanationText();
        }
       
    }

    public void ShowText()
    {
        UpdateLevelUpExplanationText();
        levelUpExplanation.enabled = true;
    }

    public void HideText()
    {
        levelUpExplanation.enabled = false;
    }

    private void UpdateLevelUpExplanationText()
    {
        if (StaticScoreHolder.currLevel + 1 < StaticScoreHolder.levels.Length) 
        {
            levelUpExplanation.text = "Level up to gain " + (StaticScoreHolder.currLevel + 1).ToString() + " extra coin per fish caught";
        } 
        else 
        {
            levelUpExplanation.text = "Final level achieved";
        }  
    }
}
