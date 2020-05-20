using UnityEngine;

public class ArrayExample : MonoBehaviour
{
    int[] scores = new int[5];
    void Start()
    {
        scores[0] = 10;
        scores[1] = 20;
        scores[2] = 30;
        scores[3] = 40;
        scores[4] = 50;

        Debug.Log(scores[0]);
        Debug.Log(scores[1]);
        Debug.Log(scores[2]);
        Debug.Log(scores[3]);
        Debug.Log(scores[4]);
    }
}
