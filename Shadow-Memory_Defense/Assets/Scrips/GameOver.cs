using Unity.VisualScripting;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public float playerDead;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Kills player after Game Over
        if (playerDead >= 1)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
