using System.Collections.Generic;
using UnityEngine;

public class Lessons : MonoBehaviour
{
    private const string Gun = nameof(Gun);
    private const string Player = nameof(Player);

    [SerializeField]
    private Camera _camera;

    [SerializeField]
    private SpriteRenderer _background;

      
    [SerializeField]
    private CharacterView _characterView;

    [SerializeField]
    private SpriteAnimationConfig _spriteAnimationConfig;

    [SerializeField]
    private CannonView _cannonView;

    [SerializeField]
    private List<BulletView> _bullets;

    [SerializeField]
    private CanvasView _canvasView;

    [SerializeField]
    private ColliderHandler _colliderHandler;

    [SerializeField]
    private AIConfig _config;

    [SerializeField]
    private EnemyView _enemyView;


    private ParalaxManager _paralaxManager;
    private SpriteAnimator _spriteAnimator;
    //private MainHeroWalker _mainHeroWalker;
    private MainHeroPhysicsWalker _mainHeroPhysicsWalker;
    private AimingMuzzle _aimingMuzzle;
    private BulletsEmitter _bulletsEmitter;
    private CanvasController _canvasController;
    private SimplePatrolAI _simplePatrolAI;
    private ObjectAnmation _objectsAnimation;
         

    private void Awake()
    {
        //_player = Resources.Load<GameObject>(Player);
        //Instantiate(_player);
    }

    private void Start()
    {
        _paralaxManager = new ParalaxManager(_camera, _background.transform);
        _spriteAnimator = new SpriteAnimator(_spriteAnimationConfig);
        //_mainHeroWalker = new MainHeroWalker(_characterView, _spriteAnimator);
        _mainHeroPhysicsWalker = new MainHeroPhysicsWalker(_characterView, _spriteAnimator);
        _aimingMuzzle = new AimingMuzzle(_cannonView.transform, _characterView.transform);
        _bulletsEmitter = new BulletsEmitter(_bullets, _cannonView.MuzzleTransform);
        _canvasController = new CanvasController(_canvasView, _colliderHandler);
        _simplePatrolAI = new SimplePatrolAI(_enemyView, new SimplePatrolAIModel(_config));
        _objectsAnimation = new ObjectAnmation(_enemyView, _spriteAnimator);

    }

    private void Update()
    {
        _paralaxManager.Update();
        _spriteAnimator.Update();
        //_mainHeroWalker.Update();
        _aimingMuzzle.Update();
        _bulletsEmitter.Update();
        _canvasController.Update();
        _objectsAnimation.Update();


    }

    private void FixedUpdate()
    {
        _mainHeroPhysicsWalker.FixedUpdate();
        _simplePatrolAI.FixedUpdate(_characterView.transform);
    }

    private void OnDestroy()
    {
        
    }
}
