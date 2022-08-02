using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusView : MonoBehaviour, IInteractive
{
    
    [SerializeField]
    private float _speedAnimation;

    [SerializeField]
    private SpriteRenderer _spriteRenderer;

  
    public float SpeedAnimation => _speedAnimation;

    public SpriteRenderer SpriteRenderer => _spriteRenderer;


}
