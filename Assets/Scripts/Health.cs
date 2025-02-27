using UnityEngine;

public class Health : MonoBehaviour
{
   public int points = 5;

   private void OnTriggerEnter(Collider other)
   {
      if (other.CompareTag("Trap"))
      {
         //HW: DO NOT DETROY
         //Move the player to start
         //Reset points to 5
         Damage(1);
      }
   }
   // To remove some health points
   private void Damage(int value)
   {
      points = points - value;
      if (points < 1)
      {
        Destroy(gameObject); 
      }
   }
}
