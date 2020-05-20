using System.Collections;
using UnityEngine;

public class StackExample : MonoBehaviour
{
    Stack myStack = new Stack();
    void Start()
    {
        myStack.Push(1);
        myStack.Push(2);
        myStack.Push(3);

        Debug.Log(myStack.Peek());
        Debug.Log(myStack.Peek());
        Debug.Log(myStack.Peek());
    }
}

class emptyClass
{

}
