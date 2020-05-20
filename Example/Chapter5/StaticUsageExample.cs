using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticUsageExample : MonoBehaviour
{
    void Start()
    {
        Member john = new Member("john", 21);
        Member jane = new Member("jane", 23);

        Debug.Log(Member.NumOfMembers);
    }
}

class Member
{
    public string name;
    public int age;
    public static int NumOfMembers;

    public Member(string name, int age)
    {
        this.name = name;
        this.age = age;
        NumOfMembers ++;
    }
}
