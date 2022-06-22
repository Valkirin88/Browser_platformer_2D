﻿using System.Collections.Generic;
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
    private SpriteRenderer _fireball;
    
    [SerializeField]
    private CharacterView _characterView;

    [SerializeField]
    private SpriteAnimationConfig _spriteAnimationConfig;

    //[SerializeField]
    //private CannonView _cannonView;

    [SerializeField]
    private List<BulletView> _bullets;

    private ParalaxManager _paralaxManager;
    private SpriteAnimator _spriteAnimator;
    private MainHeroWalker _mainHeroWalker;
    private AimingMuzzle _aimingMuzzle;
    private BulletsEmitter _bulletsEmitter;
    private GunShooter _gunShooter;

    private GameObject _gun;
    private GameObject _player;
        

    private void Awake()
    {
        _gun = Resources.Load<GameObject>(Gun);
        Instantiate(_gun);
        _player = Resources.Load<GameObject>(Player);
        Instantiate(_player);
    }

    private void Start()
    {
        _paralaxManager = new ParalaxManager(_camera, _background.transform);
        _spriteAnimator = new SpriteAnimator(_spriteAnimationConfig);
        _mainHeroWalker = new MainHeroWalker(_characterView, _spriteAnimator);
        //_aimingMuzzle = new AimingMuzzle(_cannonView.transform, _characterView.transform);
       // _bulletsEmitter = new BulletsEmitter(_bullets, _cannonView.MuzzleTransform);
        _gunShooter = new GunShooter(_gun, _player.transform);
       
    }

    private void Update()
    {
        _paralaxManager.Update();
        _spriteAnimator.Update();
        _mainHeroWalker.Update();
        //_aimingMuzzle.Update();
        //_bulletsEmitter.Update();
        _gunShooter.Update();
    }

    private void FixedUpdate()
    {
        
    }

    private void OnDestroy()
    {
        
    }
}
