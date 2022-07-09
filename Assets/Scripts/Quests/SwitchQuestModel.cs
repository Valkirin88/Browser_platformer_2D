using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchQuestModel : IQuestModel
{
    public bool TryComplete(GameObject activator)
    {
        return activator.GetComponent<CharacterView>();
    }
}
