using UnityEngine;
using exampleNS;

public class NamespaceExample : MonoBehaviour
{
    void Start()
    {   
        // using 을 이용한 첫 번째 방법
        ExampleClass obj = new ExampleClass();
        // using을 이용하지 않는 두 번째 방법
        exampleNS.exampleClass obj2 = new exampleNS.exampleClass();
    }
}

namespace exampleNS
{
    class exampleClass
    {

    }
}