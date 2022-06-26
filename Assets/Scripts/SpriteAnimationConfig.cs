using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SpriteAnimationConfig", menuName = "Configs/SpriteAnimationConfig")]
public class SpriteAnimationConfig : ScriptableObject
{
    [SerializeField]
    private List<SpritesSequence> _sequences;

    public List<SpritesSequence> Sequences => _sequences;
}
