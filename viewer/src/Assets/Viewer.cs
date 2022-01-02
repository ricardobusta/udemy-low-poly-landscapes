using UnityEngine;

public class Viewer : MonoBehaviour
{
    public float speed = 10;

    void Update()
    {
        transform.Rotate(0, speed*Time.deltaTime, 0);
    }
}
