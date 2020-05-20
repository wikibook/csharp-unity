using UnityEngine;

public class ObjectExample : MonoBehaviour
{
    void Start()
    {
        Human Alice = new Human();

        Alice.name = "alice";
        Debug.Log(Alice.name);
        Alice.Walk();
    }
}
