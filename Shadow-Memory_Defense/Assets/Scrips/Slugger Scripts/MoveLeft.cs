using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 40.0f;
    // Move slugger left
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * speed);
    }
}
