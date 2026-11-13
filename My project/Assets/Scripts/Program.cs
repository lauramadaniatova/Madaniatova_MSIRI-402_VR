
using UnityEngine;

public class Program : MonoBehaviour
{
    public int age = 21;
    public int course = 4;
    public int group = 202;

    void Start()
    {
        Debug.Log("Информация о студенте:");
        Debug.Log("Возраст: " + age);
        Debug.Log("Курс: " + course);
        Debug.Log("Группа: " + group);
    }

    public void ShowInfo()
    {
        Debug.Log("Возраст: " + age);
        Debug.Log("Курс: " + course);
        Debug.Log("Группа: " + group);
    }
}
