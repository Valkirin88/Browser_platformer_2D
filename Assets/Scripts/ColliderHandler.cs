using System;
using UnityEngine;

public class ColliderHandler : MonoBehaviour
{
    public Action OnDied { get; set; }
    public Action OnAllBonusGot { get; set; }
    private int _bonusCounter;
    private void OnTriggerEnter2D(Collider2D collision)
    {
      if(collision.GetComponent<BonusView>() !=null)
        {
            collision.gameObject.SetActive(false);
            _bonusCounter++;
            if(_bonusCounter == 1)
            {
                OnAllBonusGot?.Invoke();
            }
        }
      else if(collision.GetComponent<BottomView>() != null)
        {
            collision.gameObject.SetActive(false);
            _bonusCounter = 0;
            OnDied?.Invoke();
            
        }
    }
}
