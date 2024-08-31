using UnityEngine;

[CreateAssetMenu(fileName = "NewPlayerStats", menuName = "ScriptableObjects/PlayerStats", order = 1)]
public class PlayerStats : ScriptableObject
{
    public enum PlayerPosition
    {
        Defender,
        Attacker,
        GoalKeeper
    }

    [Header("Player Information")]
    public PlayerPosition playerPosition;  // This will now be a dropdown in the Inspector

    [Header("Attributes")]
    [Range(0, 12)] public int stamina;
    [Range(0, 12)] public int speed;
    [Range(0, 12)] public int strength;
    [Range(0, 12)] public int accuracy;
    [Range(0, 12)] public int shotPower;
}
