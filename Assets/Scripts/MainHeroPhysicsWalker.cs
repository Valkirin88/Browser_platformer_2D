using UnityEngine;

public class MainHeroPhysicsWalker
{

    private const string Horizontal = nameof(Horizontal);
    private const string Vertical = nameof(Vertical);

    private CharacterView _characterView;
    private SpriteAnimator _spriteAnimator;
    private ContactsPoller _contactsPoller;

    public MainHeroPhysicsWalker(CharacterView characterView, SpriteAnimator spriteAnimator)
    {
        _characterView = characterView;
        _spriteAnimator = spriteAnimator;
        _contactsPoller = new ContactsPoller(characterView.Collider);

    }

    public void FixedUpdate()
    {
        var doJump = Input.GetAxis(Vertical) > 0;
        var xAxisInput = Input.GetAxis(Horizontal);

        _contactsPoller.Update();

        var isGoSideWay = Mathf.Abs(xAxisInput) > _characterView.MovingTresh;

        if (isGoSideWay)
            _characterView.SpriteRenderer.flipX = xAxisInput < 0;

        var newVelocityX = 0f;

        if (isGoSideWay && 
            (xAxisInput > 0 || !_contactsPoller.HasLeftContacts) && 
            (xAxisInput < 0 || !_contactsPoller.HasRightContacts))
        {
            newVelocityX = Time.fixedDeltaTime * _characterView.WalkSpeed * (xAxisInput < 0 ? -1 : 1);
        }

        _characterView.Rigidbody.velocity = _characterView.Rigidbody.velocity.Change(x: newVelocityX);

        if (_contactsPoller.IsGrounded && doJump && Mathf.Abs(_characterView.Rigidbody.velocity.y) <= _characterView.FlyTresh)
        {
            _characterView.Rigidbody.AddForce(Vector2.up * _characterView.JumpStartSpeed);
        }        

        if (_contactsPoller.IsGrounded)
        {
            _spriteAnimator.StartAnimation(_characterView.SpriteRenderer, isGoSideWay ? Track.walk : Track.idle, true, _characterView.AnimationsSpeed);
        }
        else if (Mathf.Abs(_characterView.Rigidbody.velocity.y) > _characterView.FlyTresh)
        {
            _spriteAnimator.StartAnimation(_characterView.SpriteRenderer, Track.jump, true, _characterView.AnimationsSpeed); 
        }
        
    }

}
