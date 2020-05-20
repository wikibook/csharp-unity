using UnityEngine;

public class StructExample : MonoBehaviour
{
    void Start()
    {
      Point_struct point = new Point_struct(1,1);
      Debug.Log(point.GetPoint());
    }
}

struct Point_struct
{
    public int x;
    public int y;

    public Point_struct(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public string GetPoint()
    {
        return $"({x}, {y})";
    }    
}
