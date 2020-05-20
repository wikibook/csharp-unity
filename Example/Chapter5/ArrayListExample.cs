using System.Collections;
using UnityEngine;

public class ArrayListExample : MonoBehaviour
{
    ArrayList myAL = new ArrayList();
    void Start()
    {
        // ArrayList Add
        myAL.Add(134);          // {134}
        myAL.Add("Hello");      // {134, "Hello"}
        myAL.Add(1275.97f);     // {134, "Hello", 1275.97f}

        // // ArrayList Remove
        myAL.Remove("Hello");   // {134, 1275.97f}
        myAL.RemoveAt(0);       // {1275.97f}

        // // ArrayList insert
        myAL.Insert(0,"World"); // {"World", 1275.97f}
        myAL.Insert(0,"Hello"); // {"Hello", "World", 1275.97f}

        Debug.Log(myAL[0]);
        Debug.Log(myAL[1]);
        Debug.Log(myAL[2]);
    }
}
