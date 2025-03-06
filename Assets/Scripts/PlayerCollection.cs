using UnityEngine;

public class PlayerCollection : MonoBehaviour
{
    // hw; add a scoring system here
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
