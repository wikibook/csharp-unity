using UnityEngine;

public class EnumExample : MonoBehaviour
{
    void Start()
    {
        Debug.Log((int)Days.Mon);
        Debug.Log((int)Days.Tue);
        Debug.Log((int)Days.Wed);
        Debug.Log((int)Days.Thu);
        Debug.Log((int)Days.Fri);
        Debug.Log((int)Days.Sat);
        Debug.Log((int)Days.Sun);
    }
}

enum Days
{
    Mon = 3, Tue, Wed, Thu = 12, Fri, Sat, Sun
}