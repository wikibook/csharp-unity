using UnityEngine;

public class LambdaExample : MonoBehaviour
{
    delegate int myDelegate(int a, int b);
    void Start()
    {
        myDelegate del = (a, b) => a + b;
        Debug.Log(del(1, 3));
    }
}