using UnityEngine;

public class PlayerAttributes : MonoBehaviour
{
    public PlayerStats playerStats; // Assign the appropriate ScriptableObject in the Inspector

    private int totalPoints = 100;

    void Start()
    {
        // Initialize or load player stats if needed
        Debug.Log("Initial stats for " + playerStats.playerPosition + ":");
        Debug.Log("Stamina: " + playerStats.stamina);
        Debug.Log("Speed: " + playerStats.speed);
        Debug.Log("Strength: " + playerStats.strength);
        Debug.Log("Accuracy: " + playerStats.accuracy);
        Debug.Log("Shot Power: " + playerStats.shotPower);
    }

    // Method to calculate the cost of upgrading a stat
    private int GetUpgradeCost(int currentStat)
    {
        return (currentStat + 1) * 2; // Cost increases with stat level
    }

    // Method to upgrade a specific stat
    public bool UpgradeStat(string statName)
    {
        int statValue = 0;
        int cost = 0;

        switch (statName)
        {
            case "stamina":
                statValue = playerStats.stamina;
                cost = GetUpgradeCost(statValue);
                if (statValue < 12 && totalPoints >= cost)
                {
                    playerStats.stamina++;
                    totalPoints -= cost;
                    return true;
                }
                break;
            case "speed":
                statValue = playerStats.speed;
                cost = GetUpgradeCost(statValue);
                if (statValue < 12 && totalPoints >= cost)
                {
                    playerStats.speed++;
                    totalPoints -= cost;
                    return true;
                }
                break;
            case "strength":
                statValue = playerStats.strength;
                cost = GetUpgradeCost(statValue);
                if (statValue < 12 && totalPoints >= cost)
                {
                    playerStats.strength++;
                    totalPoints -= cost;
                    return true;
                }
                break;
            case "accuracy":
                statValue = playerStats.accuracy;
                cost = GetUpgradeCost(statValue);
                if (statValue < 12 && totalPoints >= cost)
                {
                    playerStats.accuracy++;
                    totalPoints -= cost;
                    return true;
                }
                break;
            case "shotPower":
                statValue = playerStats.shotPower;
                cost = GetUpgradeCost(statValue);
                if (statValue < 12 && totalPoints >= cost)
                {
                    playerStats.shotPower++;
                    totalPoints -= cost;
                    return true;
                }
                break;
            default:
                Debug.LogWarning("Invalid stat name: " + statName);
                break;
        }

        Debug.LogWarning("Not enough points to upgrade or stat is already maxed out.");
        return false;
    }

    public int GetRemainingPoints()
    {
        return totalPoints;
    }
}
