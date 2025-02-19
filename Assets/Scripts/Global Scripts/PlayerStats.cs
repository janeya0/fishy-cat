using System;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerStats
{
    public int CurrentLevel { get; private set; }
    public int TotalCoins { get; private set; }
    public int CoinMultiplier { get; private set; }
    

    public Dictionary<int, int> levelUpThresholds = new Dictionary<int, int>()
    {
        { 1, 10 }, 
        { 2, 20 }, 
        { 3, 50 }, 
        { 4, 100 },
        { 5, 200 },
        { 6, 400 },
        { 7, 700 }
    };

    public event Action OnTotalCoinsChanged;
    public event Action<int> OnLevelUp;

    public PlayerStats()
    {
        CurrentLevel = 0;
        CoinMultiplier = 1;
        TotalCoins = 0;
    }

    public void AddCoins(int amount) 
    {
        TotalCoins += amount * CoinMultiplier;
        OnTotalCoinsChanged?.Invoke();
        if (IsLevelUp())
        {
            PerformLevelUp();
            PerformCatUnlock();
        }
    }

    private bool IsLevelUp() 
    {
        if (levelUpThresholds.ContainsKey(CurrentLevel + 1) && TotalCoins >= levelUpThresholds[CurrentLevel + 1])
        {
            return true;
        }
        return false;
    }

    private void PerformLevelUp()
    {
        CurrentLevel += 1;
        CoinMultiplier += 1;
        OnLevelUp?.Invoke(CurrentLevel);
        // TODO: update level up text (move from LevelUp.cs to here)
    }

    private void PerformCatUnlock()
    {
        // TODO: intro new cat for level unlock
    }
}
