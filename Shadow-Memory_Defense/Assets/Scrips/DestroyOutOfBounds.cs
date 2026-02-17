using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 15;
    private float lowerBound = 15;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
 void OnTriggerEnter(Collider other)
    {
        // Check if the object the projectile collided with has the "Enemy" tag
        if (other.gameObject == GameObject.FindGameObjectWithTag("Finish"))
        {
            Destroy(other.gameObject);
        }

    }
}
