using UnityEngine;

public class PlayerTrap : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //only destroy if collectable
        if (other.CompareTag("Collectable"))
        {
            
        }
        Destroy(other.gameObject);
    }
}
