using UnityEngine;

public class MethodOverloadExample : MonoBehaviour
{
    void Start()
    {
        Debug.Log(Add(1, 3));
        Debug.Log(Add(2.0f, 3.1f));
        Debug.Log(Add(2.0d, 3.1d));
    }

    int Add(int a, int b)
    {
        return a + b;
    }

    float Add(float a, float b)
    {
        return a + b;
    }

    double Add(double a, double b)
    {
        return a + b;
    }
}

