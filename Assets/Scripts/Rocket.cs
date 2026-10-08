using UnityEngine;

public class Rocket : MonoBehaviour
{
    private float speed = 5f;

    // Moves Rocket forward
    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }
}
