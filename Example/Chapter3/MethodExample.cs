using UnityEngine;

public class MethodExample : MonoBehaviour
{
    void Start()
    {
        float result = Half(4);
        Debug.Log(result);
    }

    float Half(float num)
    {
        return num / 2;
    }
}
