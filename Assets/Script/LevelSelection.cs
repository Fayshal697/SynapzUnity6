using UnityEngine;

public class LevelSelection : MonoBehaviour
{
    public SceneController sceneController;

    public void SelectLevel(int levelNumber) {
        PlayerPrefs.SetInt("SelectedLevel", levelNumber);
        sceneController.LoadScene("Gameplay");
    }
}
