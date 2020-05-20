using UnityEngine;

public class ConstructorExample : MonoBehaviour
{
    void Start()
    {
        Human Alice = new Human("alice", 23, 160);

        Debug.Log(Alice.name);
        Debug.Log(Alice.age);
        Debug.Log(Alice.height);
    }
}