using UnityEngine;
using UnityEngine.UI;

public class CanvasView : MonoBehaviour
{
    [SerializeField]
    private Image _image;

    [SerializeField]
    private Button _restartButton;
    private bool isRestart;

    public Image Image  => _image;

    public Button RestartButton => _restartButton;

    public bool IsRestart { get; set; }

    public void RestartGame()

    {
        IsRestart = true;
               
    }
}
