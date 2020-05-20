using UnityEngine;

public class ForEachExample : MonoBehaviour
{
    void Start()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        foreach (int item in numbers)
        {
            Debug.Log(item);
        }
    }
}
