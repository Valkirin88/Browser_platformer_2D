using Pathfinding;
using UnityEngine;

public class EnemyView : MonoBehaviour, IInteractive
{
    [SerializeField]
    private Rigidbody2D _rigidbody;

    [SerializeField]
    private float _speedAnimation;

    [SerializeField]
    private SpriteRenderer _spriteRenderer;

    [SerializeField]
    private AIPath _aIPath;
    
    public Rigidbody2D Rigidbody => _rigidbody;

    public float SpeedAnimation  => _speedAnimation;

    public SpriteRenderer SpriteRenderer  => _spriteRenderer;

    public AIPath AIPath  => _aIPath;

   
}
