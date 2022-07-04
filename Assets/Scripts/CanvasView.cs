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
  
    public bool IsRestart { get; set; }

    public Image ImageLevelComplete => _imageLevelComplete;

    public Image ImageGameOver => _imageGameOver;

    public Button RestartButton => _restartButton;

    public void RestartGame()

    {
        IsRestart = true;
    
    }
}
