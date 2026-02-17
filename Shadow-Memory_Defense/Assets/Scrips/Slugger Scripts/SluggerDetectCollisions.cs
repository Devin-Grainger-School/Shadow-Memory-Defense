using UnityEngine;

public class SluggerDetectCollisions : MonoBehaviour
{
    //Destory Monsters on Collision
    void OnTriggerEnter(Collider other)
    {
        // Check if the object the projectile collided with has the "Enemy" tag
        if (other.gameObject == GameObject.FindGameObjectWithTag("Respawn"))
        {
            Destroy(other.gameObject);
        }

    }
}
