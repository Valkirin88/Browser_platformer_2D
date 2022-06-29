using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasController : IDisposable
{
    private CanvasView _canvasView;
    private ColliderHandler _colliderHandler;

    public CanvasController(CanvasView canvasView, ColliderHandler colliderHandler)
    {
        _canvasView = canvasView;
        _colliderHandler = colliderHandler;

        _colliderHandler.OnDied += ShowGameOver;
    }

    
    public void ShowGameOver()
    {
        _canvasView.Image.gameObject.SetActive(true);
        Time.timeScale = 0;
        _canvasView.RestartButton.gameObject.SetActive(true);
    }

    public void Dispose()
    {
        _colliderHandler.OnDied -= ShowGameOver;
        _canvasView.Image.gameObject.SetActive(false);
      
    }

    public void Update()
    {
        if (_canvasView.IsRestart == true)
        {
            SceneManager.LoadScene(0);
            Time.timeScale = 1;
            _canvasView.IsRestart = false;
            
        }
        
    }

}
