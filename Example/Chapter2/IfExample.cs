using UnityEngine;

public class IfExample : MonoBehaviour
{
    void Start()
    {
        int a = 10;
        if (a <= 5)
        {
            Debug.Log(a);
        }
        else if (a < 10)
        {
            Debug.Log("a가 5보다 크고 10보다 작습니다.");
        }
        else if (a < 15)
        {
            Debug.Log("a가 10보다 크거나 같고 15보다 작습니다.");
        }
        else
        {
            Debug.Log("a가 15보다 크거나 같습니다.");
        }
    }
}
