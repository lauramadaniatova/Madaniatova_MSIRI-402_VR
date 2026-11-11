
using UnityEngine;

public class MachineController : MonoBehaviour
{
    public Transform spindle;
    public float rotationSpeed = 500f;

    private bool isRunning = false;

    void Start()
    {
        Debug.Log("Станок готов к работе");
    }

    void Update()
    {
        if (isRunning && spindle != null)
        {
            spindle.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
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
