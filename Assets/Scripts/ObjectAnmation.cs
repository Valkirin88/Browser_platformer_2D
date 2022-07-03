using UnityEngine;

public class ObjectAnmation
{

    private SpriteAnimator _spriteAnimator;
    private EnemyView _enemyView;
     private Vector3 _previousPosition = new Vector3(0,0,0);

    public ObjectAnmation(EnemyView enemyView, SpriteAnimator spriteAnimator)
    {
        _enemyView = enemyView;
        _spriteAnimator = spriteAnimator;
      
    }

    public void Update()
    {
        FlipXAccordingDuration();
        _spriteAnimator.StartAnimation(_enemyView.SpriteRenderer, Track.enemy_animation, true, _enemyView.SpeedAnimation);
    }

    public void FlipXAccordingDuration()
    {
        
        if (_enemyView.transform.position.x - _previousPosition.x > 0)
        {
            _enemyView.SpriteRenderer.flipX = true;
        }
        else if(_enemyView.transform.position.x - _previousPosition.x < 0)
        { _enemyView.SpriteRenderer.flipX = false; }
        _previousPosition.x = _enemyView.transform.position.x;
    }

}
