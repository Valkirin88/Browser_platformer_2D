using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyView : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D _rigidbody;

    [SerializeField]
    private float _speedAnimation;

    [SerializeField]
    private SpriteRenderer _spriteRenderer;

    public Rigidbody2D Rigidbody => _rigidbody;

    public float SpeedAnimation  => _speedAnimation;

    public SpriteRenderer SpriteRenderer  => _spriteRenderer; 
}
