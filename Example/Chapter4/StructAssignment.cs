using UnityEngine;

public class StructAssignment : MonoBehaviour
{
    void Start()
    {
        Point_struct point1 = new Point_struct(1, 1);
        Point_struct point2 = point1;

        Debug.Log(point1.GetPoint());
        Debug.Log(point2.GetPoint());
    }
}