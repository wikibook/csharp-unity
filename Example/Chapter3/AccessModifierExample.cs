using UnityEngine;

public class AccessModifierExample : MonoBehaviour
{
    void Start()
    {
        Human Alice = new Human("alice", 23, 160);
        Debug.Log(Alice.name);
    }
}
