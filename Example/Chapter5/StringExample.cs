using UnityEngine;
using System;

public class StringExample : MonoBehaviour
{
    void Start()
    {
        string str1 = "Hello";
        string str2 = "Hello World!";

        StringExample ads= new StringExample();

        Debug.Log(str1.Length);
        Debug.Log(str2.Length);

        string str3 = "abcde";
        string str4 = "aeiou";

        Debug.Log(str3.IndexOf("e"));
        Debug.Log(str3.IndexOf("cde"));
        Debug.Log(str4.IndexOf("bcd"));

        string str5 = "abcde";
        Debug.Log(str5.Replace("cd", "dc"));

        string str6 = "apple";
        string[] arr = str6.Split('p');
        Debug.Log(arr[0]);
        Debug.Log(arr[1]);
        Debug.Log(arr[2]);

        string str7 = "This is C#";
        Debug.Log(str7.Substring(5, 2)); // 4번 인덱스부터 6개의 문자 출력
        Debug.Log(str7.Substring(8)); //8번 인덱스부터 끝까지 출력
        Debug.Log(str7.Substring(str7.IndexOf("s")));

        string str8 = String.Format("4 + 8의 값은 {0}입니다.", 4 + 8);
        Debug.Log(str8);
        
        string a = "12";
        double b = double.Parse(a);
    }

}

