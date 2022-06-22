using System.Collections;
using System;
using UnityEngine;
using Object = System.Object;

public class GunShooter 
{
    private GameObject _gun;
    private Transform _mainCharacterTransform;
    private SpriteRenderer _fireball;

    public GunShooter(GameObject gun, Transform mainCharacterTransform)
    {
        _gun = gun;
        _mainCharacterTransform = mainCharacterTransform;
      // _fireball = fireball;
        
    }

    public void Update()
    {
        _gun.transform.LookAt(_mainCharacterTransform);
        //Instantiate(_fireball);
        Debug.Log("123");
    }
}
