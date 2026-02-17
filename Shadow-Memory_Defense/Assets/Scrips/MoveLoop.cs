using UnityEngine;

public class MoveLoop : MonoBehaviour
{
    public GameObject icon;
    public float speed;

    public void Update()
    {
        float y = Mathf.PingPong(Time.time * speed, 0.5f);
        icon.transform.localPosition = new Vector3(0, y, 0);
    }
}
