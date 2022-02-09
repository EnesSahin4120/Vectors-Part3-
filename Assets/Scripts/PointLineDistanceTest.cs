using UnityEngine;

public class PointLineDistanceTest : MonoBehaviour
{
    public Vector3 lineDirection;
    public Vector3 point;
    public Vector3 pointOnLine;
    void Start()
    {
        Coordinates _lineDirection = new Coordinates(lineDirection);
        Coordinates _point = new Coordinates(point);
        Coordinates _pointOnLine = new Coordinates(pointOnLine);

        float distance = Mathematics.DistancePointToLine(_point, _pointOnLine, _lineDirection);
        Debug.Log(distance);
    }
}
