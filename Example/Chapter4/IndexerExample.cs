using UnityEngine;

public class IndexerExample : MonoBehaviour
{
    void Start()
    {
        Grade grades = new Grade();

        grades[3] = 57;
        grades[8] = 12;

        for (int i = 0; i < 10; i++)
        {
            Debug.Log(grades[i]);
        }

    }
}

class Grade
{
    public int[] grades = { 24, 75, 90, 74, 51, 74, 83, 52, 31, 58 };

    public int this[int index]
    {
        get
        {
            return grades[index];
        }

        set
        {
            grades[index] = value;
        }
    }
}

