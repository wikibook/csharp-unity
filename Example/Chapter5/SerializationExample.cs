using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SerializationExample : MonoBehaviour
{
    void Start()
    {
        // 예제 데이터 생성
        exampleData data = new exampleData();
        data.number = 1756;
        data.text = "Hello";

        // 객체를 파일 형태로 저장
        FileStream fs = new FileStream("/Users/kkirru/Desktop/data.dat", FileMode.Create); 
        BinaryFormatter bf = new BinaryFormatter();
        bf.Serialize(fs, data);
        fs.Close();

        // 저장된 파일로부터 객체 불러오기
        fs = new FileStream("/Users/kkirru/Desktop/data.dat", FileMode.Open); 
        exampleData loadedData = (exampleData)bf.Deserialize(fs);
        Debug.Log(loadedData.number);
        Debug.Log(loadedData.text);
    }
}

[System.Serializable]
class exampleData 
{
    public int number;
    public string text;
}