using UnityEngine;

public class EventExample : MonoBehaviour
{
    void Start()
    {
        Subscriber sub = new Subscriber();
        Publisher pub = new Publisher();

        pub.RunEvent();
    }
}

delegate void myEventHandler();
class Publisher
{
    public static event myEventHandler myEvent;
    public void RunEvent()
    {
        if (myEvent != null)
        {
            myEvent();
        }
    }
}

class Subscriber
{
    public Subscriber()
    {
        Publisher.myEvent += DoSomething;
    }

    public void DoSomething()
    {
        Debug.Log("event 발생!");
    }
}