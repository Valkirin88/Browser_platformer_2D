using UnityEngine;
using UnityEngine.UI;

public class CanvasView : MonoBehaviour
{
    [SerializeField]
    private Image _imageGameOver;

    [SerializeField]
    private Image _imageLevelComplete;

    [SerializeField]
    private Button _restartButton;
    private bool isRestart;

   
    public bool IsRestart { get; set; }

    public Image ImageLevelComplete => _imageLevelComplete;

    public Image ImageGameOver => _imageGameOver;

    public Button RestartButton => _restartButton;

    public void RestartGame()

    {
        Debug.Log("123");
        IsRestart = true;
               
    }
}
