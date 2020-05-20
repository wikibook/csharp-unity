using UnityEngine;

public class EnumWithArray : MonoBehaviour
{
    string[] students = { "john", "emily", "tom", "sophia", "noah" };
    void Start()
    {
        Debug.Log(students[(int)Students.emily]); // emily 출력
        Debug.Log(students[(int)Students.noah]); // noah 출력
    }

    enum Students
    {
        john, emily, tom, sophia, noah
    }
}
