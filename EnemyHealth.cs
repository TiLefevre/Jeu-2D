using UnityEngine;

public class HealthScript : MonoBehaviour
{
  
  public int hp = 2;

   public GameObject objectToDestroy;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("bullet"))
        {
            hp = hp - 1;
            if(hp <= 0)
            {
              Destroy(objectToDestroy);
            }
        }
    }
  

  
}
