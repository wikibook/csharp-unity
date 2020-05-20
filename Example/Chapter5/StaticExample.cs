using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticExample : MonoBehaviour
{
    void Start()
    {
        ExampleClass.number = 1;
        ExampleClass.Hello();
    }
}

class ExampleClass
{
    public static int number;

    public static void Hello()
    {
        Debug.Log("Hello");
    }
}
