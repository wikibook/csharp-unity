using System.Collections;
using UnityEngine;

public class CoroutineExample : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(First());
        Debug.Log("3");
    }

    IEnumerator First()
    {
        Debug.Log("1");
        yield return null;
        StartCoroutine(Second());
    }

    IEnumerator Second()
    {
        Debug.Log("2");
        yield return new WaitForSeconds(0.3f);
    }
}
