
public class EnemyAnimation
{

    private SpriteAnimator _spriteAnimator;
    private EnemyView _enemyView;
    private CharacterView _characterView;

    public EnemyAnimation(EnemyView enemyView, SpriteAnimator spriteAnimator, CharacterView characterView)
    {
        _enemyView = enemyView;
        _characterView = characterView;
        _spriteAnimator = spriteAnimator;
    }

    public void Update()
    {
        if(_enemyView.transform.position.x - _characterView.transform.position.x > 0)
            _enemyView.SpriteRenderer.flipX = false;
        else
        { _enemyView.SpriteRenderer.flipX = true; }
        _spriteAnimator.StartAnimation(_enemyView.SpriteRenderer, Track.enemy_animation, true, _enemyView.SpeedAnimation);
    }

}
