using UnityEngine;

public class DelegateExample : MonoBehaviour
{
    delegate void ExampleDelegate();
    delegate void HumanDelegate();
    void Start()
    {
        ExampleDelegate del = Hello;
        del();

        HumanDelegate human = Walk;
        human += Eat;
        human += Sleep;

        human();
    }

    void Hello()
    {
        Debug.Log("Hello");
    }

    void Walk()
    {
        Debug.Log("Walk");
    }

    void Eat()
    {
        Debug.Log("Eat");
    }
    void Sleep()
    {
        Debug.Log("Sleep");
    }
}