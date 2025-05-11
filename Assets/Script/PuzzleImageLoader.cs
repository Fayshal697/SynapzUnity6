using UnityEngine;
using UnityEngine.UI;

public class PuzzleImageLoader : MonoBehaviour
{
    public string folderPath = "Assets/Resoures/Puzzles";  // path dalam Resources
    public Image[] puzzlePieces;  // drag array Image di editor

    void Start()
    {
        Texture2D[] loadedTextures = Resources.LoadAll<Texture2D>(folderPath);

        for (int i = 0; i < loadedTextures.Length && i < puzzlePieces.Length; i++)
        {
            Sprite sprite = Sprite.Create(
                loadedTextures[i],
                new Rect(0, 0, loadedTextures[i].width, loadedTextures[i].height),
                new Vector2(0.5f, 0.5f)
            );
            puzzlePieces[i].sprite = sprite;
        }
    }
}
