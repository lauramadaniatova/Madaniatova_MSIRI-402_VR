using UnityEngine;

public class CrossSlideController : MonoBehaviour
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

        if (Input.GetKey(KeyCode.A))
            direction = -1f;

        if (Input.GetKey(KeyCode.D))
            direction = 1f;

        float newX = transform.position.x +
                     direction * moveSpeed * Time.deltaTime;

        newX = Mathf.Clamp(
            newX,
            startPosition.x - moveDistance,
            startPosition.x + moveDistance
        );

        transform.position = new Vector3(
            newX,
            transform.position.y,
            transform.position.z
        );
    }
}