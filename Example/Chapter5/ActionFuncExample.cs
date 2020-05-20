using UnityEngine;
using System;

public class ActionFuncExample : MonoBehaviour
{
    void Start()
    {
        Action<string> act = (str) => Debug.Log(str);
        act("Hello");

        Func<int, int, string> func = (a, b) => "결과 : " + (a + b).ToString();
        Debug.Log(func(1, 3));
    }
}


