using UnityEngine;

public class InheritanceExample : MonoBehaviour
{
    void Start()
    {
        // 상속
        Adult john = new Adult("john", 28, 173);
        Baby lisa = new Baby("lisa", 3, 95);

        Debug.Log(john.age);
        lisa.Sleep();

        // base 키워드
        Adult maria = new Adult("maria", 10, 12);
        maria.Age = 1;
        maria.SetBaseAge(2);
        Debug.Log(maria.Age);
        Debug.Log(maria.GetBaseAge());

        // 메서드 오버라이드
        Human sujin = new Human("sujin", 12, 147);
        Baby jake = new Baby("jake", 3, 62);
        Human chris = new Baby("chris", 6, 110);

        sujin.Walk();
        jake.Walk();
        chris.Walk();
    }
}

class Adult : Human
{
    public Adult(string _name, int _age, float _height) : base(_name, _age, _height) { }

    public void PrintAddress()
    {
        Debug.Log(address);
    }

    public int Age;
    public void SetBaseAge(int age)
    {
        base.age = age;
    }

    public int GetBaseAge()
    {
        return base.age;
    }
}

class Baby : Human
{
    public Baby(string _name, int _age, float _height) : base(_name, _age, _height) { }

    public void PrintAddress()
    {
        Debug.Log(address);
    }

    public override void Walk()
    {
        Debug.Log("crawl");
    }
}
