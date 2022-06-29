using System;
using UnityEngine;

public class ColliderHandler : MonoBehaviour
{
    public Action OnDied { get; set; }
    private void OnTriggerEnter2D(Collider2D collision)
    {
      if(collision.GetComponent<BonusView>() !=null)
        {
            collision.gameObject.SetActive(false);
        }
      else if(collision.GetComponent<BottomView>() != null)
        {
            collision.gameObject.SetActive(false);
            OnDied?.Invoke();
            
        }
    }
}
