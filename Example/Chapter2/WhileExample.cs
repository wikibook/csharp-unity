using UnityEngine;

public class WhileExample : MonoBehaviour
{
    void Start()
    {
        int i = 1;
        while (i < 6)
        {
            Debug.Log(i);
            i++;
        }

        int j = 1;
        while (true)
        {
            if (j > 5)
            {
                break;
            }
            Debug.Log(j);
            j++;
        }

        int k = 1;
        while (k <= 10)
        {
            if (k % 2 == 0)
            {
                k ++;
                continue;
            }
            Debug.Log(k);
            k++;
        }
    }

}
