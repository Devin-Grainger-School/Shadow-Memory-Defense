using UnityEngine;

public class SluggerDetectCollisions : MonoBehaviour
{
    //Destory Monsters on Collision
    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);

    }
}
