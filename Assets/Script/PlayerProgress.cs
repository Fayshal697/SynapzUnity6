using UnityEngine;

public class PlayerProgress : MonoBehaviour
{
    public static void UnlockLevel(int stage, int level) {
        string key = $"Stage {stage}_Level{level}_Unlocked";
        PlayerPrefs.SetInt(key, 1);
    }

    public static bool IsLevelUnlocked(int stage, int level) {
        string key = $"Stage {stage}_Level{level}_Unlocked";
        return PlayerPrefs.GetInt(key, 0) == 1;
    }
}
