using UnityEngine;
using UnityEngine.UI;

public class LogicManager : MonoBehaviour
{
    public static LogicManager Instance;
    public static int bonus = 0;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = GlobalGameManager.Instance.PlayerStats.TotalCoins.ToString();
    }
}
