using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "QuestStoryConfig", menuName = "Quests/QuestStoryConfig")]
public class QuestStoryConfig : ScriptableObject
{
    [SerializeField]
    private QuestConfig[] _quests;

    [SerializeField]
    private QuestStoryType _questStoryType;

    public QuestConfig[] Quests  => _quests;
    public QuestStoryType QuestStoryType  => _questStoryType; 
}
public enum QuestStoryType
{
    Common,
    Resettable

}