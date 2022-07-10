using UnityEngine;

public class Lessons : MonoBehaviour
{
    
    [SerializeField]
    private Camera _camera;

    [SerializeField]
    private SpriteRenderer _background;

      
    [SerializeField]
    private CharacterView _characterView;

    [SerializeField]
    private SpriteAnimationConfig _spriteAnimationConfig;

  
    [SerializeField]
    private CanvasView _canvasView;

    [SerializeField]
    private ColliderHandler _colliderHandler;

    [SerializeField]
    private AIConfig _config;

    [SerializeField]
    private EnemyView _enemyView;

    [SerializeField]
    private BonusView _bonusView;


    private ParalaxManager _paralaxManager;
    private SpriteAnimator _spriteAnimator;
    private MainHeroPhysicsWalker _mainHeroPhysicsWalker;
    private CanvasController _canvasController;
    private SimplePatrolAI _simplePatrolAI;
    private ObjectAnmation _enemyAnimation;
    
    private void Start()
    {
        _paralaxManager = new ParalaxManager(_camera, _background.transform);
        _spriteAnimator = new SpriteAnimator(_spriteAnimationConfig);
        _mainHeroPhysicsWalker = new MainHeroPhysicsWalker(_characterView, _spriteAnimator);
        _canvasController = new CanvasController(_canvasView, _colliderHandler);
        _simplePatrolAI = new SimplePatrolAI(_enemyView, new SimplePatrolAIModel(_config));
        _enemyAnimation = new ObjectAnmation(_enemyView, _spriteAnimator);

    }

    private void Update()
    {
        _paralaxManager.Update();
        _spriteAnimator.Update();
        _canvasController.Update();
        _enemyAnimation.Update();
      
    }

    private void FixedUpdate()
    {
        _mainHeroPhysicsWalker.FixedUpdate();
        _simplePatrolAI.FixedUpdate(_characterView.transform);
    }
      
}
