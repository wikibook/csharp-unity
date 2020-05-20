using System.Collections;
using UnityEngine;

public class HashTableExample : MonoBehaviour
{
    Hashtable myHT = new Hashtable();
    void Start()
    {
        myHT.Add("first", 187);
        myHT.Add("second", 1.8f);
        myHT.Add("third", "Star");

        Debug.Log(myHT["first"]);
        Debug.Log(myHT["second"]);
        Debug.Log(myHT["third"]);
    }
}
