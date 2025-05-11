using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    public SceneController sceneController;

    public void PlayGame() {
        sceneController.LoadScene("StageSelection");
    }

    public void OpenSetting() {
        sceneController.LoadScene("Settings");
    }

    public void ExitGame() {
        sceneController.QuitGame();
    }
}
