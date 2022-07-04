using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasController : IDisposable
{
    private CanvasView _canvasView;
    private ColliderHandler _colliderHandler;
    private bool _gameStopped;

    public CanvasController(CanvasView canvasView, ColliderHandler colliderHandler)
    {
        _canvasView = canvasView;
        _colliderHandler = colliderHandler;

        _colliderHandler.OnDied += ShowGameOver;
        _colliderHandler.OnAllBonusGot += ShowLevelComplete;
    }

    private void ShowLevelComplete()
    {
        _canvasView.ImageLevelComplete.gameObject.SetActive(true);
        StopGame();
    }

    private void ShowGameOver()
    {
        _canvasView.ImageGameOver.gameObject.SetActive(true);
        StopGame();
    }

    public void Dispose()
    {
        _colliderHandler.OnDied -= ShowGameOver;
        _colliderHandler.OnAllBonusGot -= ShowLevelComplete;
        _canvasView.ImageGameOver.gameObject.SetActive(false);
    }

    public void Update()
    {
        if (!_canvasView.IsRestart)
            return;
        else if ((_gameStopped && _canvasView.IsRestart) || (_gameStopped && Input.GetKeyDown(KeyCode.Return)))
        {
            SceneManager.LoadScene(0);
            Time.timeScale = 1;
            _canvasView.IsRestart = false;
            _gameStopped = false;
         
        }
    }

    public void StopGame()
    {
        Time.timeScale = 0;
        _canvasView.RestartButton.gameObject.SetActive(true);
        _gameStopped = true;  
    }
}
