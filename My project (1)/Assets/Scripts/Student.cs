
using UnityEngine;

public class Student : MonoBehaviour
{
    public Program program;

    void Start()
    {
        if (program == null)
        {
            program = FindAnyObjectByType<Program>();
        }

        if (program != null)
        {
            int studentAge = program.age;
            int studentCourse = program.course;
            int studentGroup = program.group;

            Debug.Log("Второй класс обращается к первому!");
            Debug.Log("Возраст: " + studentAge);
            Debug.Log("Курс: " + studentCourse);
            Debug.Log("Группа: " + studentGroup);

            program.ShowInfo();
        }
    }
}
