using UnityEngine;

public class MachineController : MonoBehaviour
{
    public Transform spindle;
    public float rotationSpeed = 500f;

    private bool isRunning = true;

    void Start()
    {
        isRunning = true;
        Debug.Log("Станок запущен");

        if (spindle == null)
        {
            Debug.LogError("Шпиндель не назначен!");
        }
    }

    void Update()
    {
        if (isRunning && spindle != null)
        {
            spindle.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
        }
    }

    public void StartMachine()
    {
        isRunning = true;
        Debug.Log("Станок запущен");
    }

    public void StopMachine()
    {
        isRunning = false;
        Debug.Log("Станок остановлен");
    }
}