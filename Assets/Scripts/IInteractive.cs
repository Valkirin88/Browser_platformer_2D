
using UnityEngine;

public interface IInteractive
{
    public SpriteRenderer SpriteRenderer { get;}

    public float SpeedAnimation { get; }
    Transform transform { get; }
}