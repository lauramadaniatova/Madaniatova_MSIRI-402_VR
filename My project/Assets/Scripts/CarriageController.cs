using UnityEngine;

public class CarriageController : MonoBehaviour
{
    public float moveSpeed = 1f;
    public float moveDistance = 1f;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float direction = 0f;

        if (Input.GetKey(KeyCode.W))
            direction = 1f;

        if (Input.GetKey(KeyCode.S))
            direction = -1f;

        float newZ = transform.position.z +
                     direction * moveSpeed * Time.deltaTime;

        newZ = Mathf.Clamp(
            newZ,
            startPosition.z - moveDistance,
            startPosition.z + moveDistance
        );

        transform.position = new Vector3(
            transform.position.x,
            transform.position.y,
            newZ
        );
    }
}