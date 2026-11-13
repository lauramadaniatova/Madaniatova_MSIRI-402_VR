using UnityEngine;

public class ShapeSpawner : MonoBehaviour
{
    // Названия и количество фигур задаются заранее в массиве.
    private readonly string[] shapeNames = { "Cube", "Sphere", "Capsule" };

    private bool hasSpawned;

    private void Start()
    {
        if (hasSpawned) return;
        hasSpawned = true;

        for (int i = 0; i < shapeNames.Length; i++)
        {
            PrimitiveType primitiveType;

            if (shapeNames[i] == "Cube")
                primitiveType = PrimitiveType.Cube;
            else if (shapeNames[i] == "Sphere")
                primitiveType = PrimitiveType.Sphere;
            else
                primitiveType = PrimitiveType.Capsule;

            GameObject shape = GameObject.CreatePrimitive(primitiveType);
            shape.name = shapeNames[i];

            // Фигуры появляются рядом друг с другом над полом.
            shape.transform.position = new Vector3((i - 1) * 0.75f, 3.5f, 0f);

            Rigidbody body = shape.AddComponent<Rigidbody>();
            body.mass = 1f;

            shape.AddComponent<CollisionHandler>();
        }

        Debug.Log("Созданы фигуры: Cube, Sphere, Capsule.");
    }
}
