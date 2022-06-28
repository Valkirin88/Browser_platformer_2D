using UnityEngine;

public class BonusFinder : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
      if(collision.GetComponent<BonusView>() !=null)
        {
            collision.gameObject.SetActive(false);
        }
    }
}
