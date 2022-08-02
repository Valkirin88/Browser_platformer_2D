using UnityEngine;

public class ObjectAnmation
{

    private SpriteAnimator _spriteAnimator;
    private Vector3 _previousPosition = new Vector3(0,0,0);
    private IInteractive _interactiveObject;

    public ObjectAnmation(IInteractive interactiveObject, SpriteAnimator spriteAnimator)
    {
        _interactiveObject = interactiveObject;
        _spriteAnimator = spriteAnimator;
      
    }

    public void Update()
    {
        if (_interactiveObject.GetType() == typeof(EnemyView))

        {
            FlipXAccordingDirection();
            _spriteAnimator.StartAnimation(_interactiveObject.SpriteRenderer, Track.enemy_animation, true, _interactiveObject.SpeedAnimation);
        }

        if (_interactiveObject.GetType() == typeof(BonusView))
        {
            _spriteAnimator.StartAnimation(_interactiveObject.SpriteRenderer, Track.bonus_animation, true, _interactiveObject.SpeedAnimation);
        }
    }

    public void FlipXAccordingDirection()
    {

        if (_interactiveObject.transform.position.x - _previousPosition.x > 0)
        {
            _interactiveObject.SpriteRenderer.flipX = true;
        }
        else if (_interactiveObject.transform.position.x - _previousPosition.x < 0)
        { _interactiveObject.SpriteRenderer.flipX = false; }
        _previousPosition.x = _interactiveObject.transform.position.x;
    }

}
