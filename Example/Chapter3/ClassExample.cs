using UnityEngine;

public class ClassExample : MonoBehaviour
{

}

class Human
{
    public string name;
    public int age;
    public float height;
    protected string address;
    
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int Age
    {
        get { return age; }
        set { age = value; }
    }
    public float Height
    {
        get { return height; }
        set { height = value; }
    }

    public int GetAge()
    {
        return age;
    }

    public void SetAge(int _age)
    {
        age = _age;
    }

    public Human()
    {

    }

    public Human(string _name, int _age, float _height)
    {
        name = _name;
        age = _age;
        height = _height;
    }

    public void Eat()
    {
        Debug.Log("eat");
    }

    public virtual void Walk()
    {
        Debug.Log("walk");
    }

    public void Sleep()
    {
        Debug.Log("sleep");
    }
}

