using UnityEngine;

public class TypeConversionExample : MonoBehaviour
{
    void Start()
    {
        Adult maria = new Adult("maria", 10, 120);
        Human human = maria;

        Human jason = new Adult("jason", 32, 172); // Adult 타입 객체를 Human 타입 변수에 대입
        Adult adult = (Adult)jason;

        Human Paul = new Human("paul", 3, 90);
        Baby baby = Paul as Baby;

        if (baby == null)
        {
            Debug.Log("형변환 실패");
        }
        else
        {
            Debug.Log("형변환 성공");
        }

        Human Alexis = new Adult("alexis", 23, 155);
        Adult adult_alexis = Alexis as Adult;

        if (adult_alexis == null)
        {
            Debug.Log("형변환 실패");
        }
        else
        {
            Debug.Log("형변환 성공");
        }

    Debug.Log(Alexis is Adult);
    }
}
