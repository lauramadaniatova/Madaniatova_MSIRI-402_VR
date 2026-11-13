
using UnityEngine;

public class FlywheelController : MonoBehaviour
{
    public float rotationSpeed = 120f;

    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime, Space.Self);
        }

        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime, Space.Self);
        }
    }
}