using UnityEngine;
using System.IO;

public class FileStreamExample : MonoBehaviour
{
    void Start()
    {
        FileStream fs = new FileStream("/Users/kkirru/Desktop/text.txt", FileMode.Create); 
        
        StreamWriter sw = new StreamWriter(fs);
        sw.Write("Hello");
        sw.Close();

        fs = new FileStream("/Users/kkirru/Desktop/text.txt", FileMode.Open); 
        StreamReader sr = new StreamReader(fs);
        Debug.Log(sr.ReadLine());
        sr.Close();

        FileStream fs2 = new FileStream("/Users/kkirru/Desktop/binary.data", FileMode.Create);
        BinaryWriter bw = new BinaryWriter(fs2);
        bw.Write("Hello binary");
        bw.Write(594);
        bw.Close();

        fs2 = new FileStream("/Users/kkirru/Desktop/binary.data", FileMode.Open); 
        BinaryReader br = new BinaryReader(fs2);
        Debug.Log(br.ReadString());
        Debug.Log(br.ReadInt32());
        br.Close();
    }
}
