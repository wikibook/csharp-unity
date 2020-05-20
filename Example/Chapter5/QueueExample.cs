using System.Collections;
using UnityEngine;

public class QueueExample : MonoBehaviour
{
    Queue myQueue = new Queue();
    void Start()
    {
        myQueue.Enqueue(1);
        myQueue.Enqueue(2);
        myQueue.Enqueue(3);

        Debug.Log(myQueue.Peek());
        Debug.Log(myQueue.Peek());
        Debug.Log(myQueue.Peek());
    }
}
