using UnityEngine;

public class SwitchExample : MonoBehaviour
{
    void Start()
    {
        int a = 1;
        switch (a < 5)
        {
            case true:
                Debug.Log(a);
                break;
            case false:
                Debug.Log("a가 5보다 큽니다.");
                break;
            default:
                break;
        }

        int num = 1;
        switch (num)
        {
            case 1:
                Debug.Log("num은 1입니다.");
                break;
            case 2:
                Debug.Log("num은 2입니다");
                break;
            case 3:
                Debug.Log("num은 3입니다");
                break;
            default:
                Debug.Log("num은 1,2,3이 아닙니다");
                break;
        }
    }
}

    