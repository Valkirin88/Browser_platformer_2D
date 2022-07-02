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
           
            if(_bonusCounter == 8)
            {
                _bonusCounter = 0;
                OnAllBonusGot?.Invoke();
            }
        }
      else if(collision.GetComponent<BottomView>() || collision.GetComponent<EnemyView>())
        {
            
            _bonusCounter = 0;
            OnDied?.Invoke();
            
        }


    }
}
