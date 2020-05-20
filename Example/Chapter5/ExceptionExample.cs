using UnityEngine;

public class ExceptionExample : MonoBehaviour
{
    void Start()
    {
        int[] arr = { 1, 2, 3 };
        int sum = 0;

        try
        {
            for (int i = 0; i < 5; i++)
            {
                sum += arr[i];
            }
        }
        catch (System.IndexOutOfRangeException exception)
        {
            Debug.Log(exception.Message);
        }
        finally
        {
            Debug.Log(sum);
        }
    }
}

