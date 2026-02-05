using UnityEngine;

public class PageDetectCollision : MonoBehaviour
{
    // Destory's Monster and Page
    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Destroy(gameObject);

    }
}
