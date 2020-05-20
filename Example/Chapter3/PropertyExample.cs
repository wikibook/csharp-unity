using UnityEngine;

public class PropertyExample : MonoBehaviour
{
    void Start()
    {
        Human Alice = new Human("alice", 23, 160);
        Alice.Age = 15;
        Debug.Log(Alice.Age);

        Human Kelly = new Human("kelly", 30, 167);
        Kelly.SetAge(27);
        Debug.Log(Kelly.GetAge());
    }
}
