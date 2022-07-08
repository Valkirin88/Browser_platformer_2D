using UnityEngine;

[CreateAssetMenu(fileName = "QuestConfig", menuName = "Quests/QuestConfig")]
public class QuestConfig : ScriptableObject
{
    [SerializeField]
    private int _id;
    
    [SerializeField]
    private QuestType _questType;

    public int Id  => _id;
    public QuestType QuestType  => _questType; 
}


public enum QuestType
{
    Switch
}