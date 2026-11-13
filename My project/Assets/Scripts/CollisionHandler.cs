using UnityEngine;

[RequireComponent(typeof(Collider))]
public class CollisionHandler : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(
            gameObject.name + " столкнулся с объектом: " +
            collision.gameObject.name,
            gameObject
        );
    }
}
