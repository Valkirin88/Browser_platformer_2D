using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "QuestItemsConfig", menuName = "Quests/QuestItemsConfig")]
public class QuestItemsConfig : ScriptableObject
{
    [SerializeField]
    private int _questId;

    [SerializeField]
    private List<int> _questItemIdCollection;

    public int QuestId => _questId;

    public List<int> QuestItemIdCollection => _questItemIdCollection;
}
