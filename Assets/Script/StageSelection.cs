using UnityEngine;

public class StageSelection : MonoBehaviour
{
    public SceneController sceneController;

    public void SelectStage(int stageNumber) {
        PlayerPrefs.SetInt("SelectedStage", stageNumber);
        sceneController.LoadScene("LevelSelection");
    }
}
