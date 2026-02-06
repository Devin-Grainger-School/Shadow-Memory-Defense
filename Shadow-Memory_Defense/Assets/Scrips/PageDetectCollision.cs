using UnityEngine;

public class PageDetectCollision : MonoBehaviour
{
    public GameObject objectToDestroy;
    // Destory's Monster and Page
    void OnTriggerEnter(Collider other)
    {
        if (objectToDestroy != null)
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }

    }
}
