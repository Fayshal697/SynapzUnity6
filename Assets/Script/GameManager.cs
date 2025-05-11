using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text questionText;
    public Button doneButton;

    private string currentQuestion;
    private int selectedStage;
    private int SelectedLevel;

    void Start()
    {
        selectedStage = PlayerPrefs.GetInt("SelectedStage");
        SelectedLevel = PlayerPrefs.GetInt("SelectedLevel");

        LoadQuestion(selectedStage, SelectedLevel);
        doneButton.onClick.AddListener(CheckAnswer);
    }

    void LoadQuestion(int stage, int level) {
        //simulasi pertanyaan
        currentQuestion = $"Soal untuk stage {stage}, Level {level}";
        questionText.text = currentQuestion;
    }

    void CheckAnswer() {
        // cek jawaban player
        Debug.Log("Cek jawaban.... (implementasi lanjut di answer checker)");
    }
}
