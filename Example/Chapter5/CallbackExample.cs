using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallbackExample : MonoBehaviour
{
    void Start()
    {
        Mother mother = new Mother(); 
        Son son = new Son();
        
        mother.GetSonToStudy(son);
    }
}

delegate void StudyDelegate();

class Mother
{
    public void GetSonToStudy(Son son)
    {
        StudyDelegate del = FinishStudy;
        son.Study(del);
    }

    public void FinishStudy()
    {
        Debug.Log("Study done");
    }
}

class Son
{
    public void Study(StudyDelegate del)
    {
        del();
    }
}