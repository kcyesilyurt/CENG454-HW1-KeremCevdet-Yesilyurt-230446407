using UnityEngine;

public class FlightController : MonoBehaviour
{
    public float speed = 8f;
    public float rotationSpeed = 40f;

    void Update()
    {  // Move forward
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        // Rotate based on input ' W/S for pitch'
        float pitch = Input.GetAxis("Vertical") * rotationSpeed * Time.deltaTime;
        transform.Rotate(pitch, 0f, 0f);
        // Roll based on horizontal input 'A/D for roll'
        float roll = -Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        transform.Rotate(0f, 0f, roll);
        // Yaw based on Q and E keys
        float yaw = 0f;
        if (Input.GetKey(KeyCode.Q)) yaw = -rotationSpeed * Time.deltaTime;
        if (Input.GetKey(KeyCode.E)) yaw = rotationSpeed * Time.deltaTime;
    
        transform.Rotate(0f, yaw, 0f);
    }
}