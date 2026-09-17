using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // private float length = 1;
    private float yspeed = 5f;
    private float xspeed = .1f; // x speed is faster need lower values
 

    void Update()
    {
        Move();
        
    }

//PLAYER MOVEMENT W/ RESTRICTIONS//
    void Move()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        
            transform.Translate(Vector2.up * Mathf.Sin(Time.deltaTime) * yspeed * verticalInput);
            transform.Translate(Vector2.right * Mathf.Cos(Time.deltaTime) * xspeed * horizontalInput);
    }

}
