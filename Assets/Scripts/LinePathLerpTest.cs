using UnityEngine;

public class LinePathLerpTest : MonoBehaviour
{
    Line linePath;
    public GameObject ball;

    Line trajectory;

    public float t;

    private void Start()
    {
        linePath = new Line(new Coordinates(0, -5, 0), new Coordinates(60, 15, 0));
        linePath.Draw(0.2f, Color.red);

        ball.transform.position = linePath.A.ToVector();

        trajectory = new Line(linePath.A, linePath.Lerp(t), Line.LINETYPE.SEGMENT);
    }

    private void Update()
    {
        if (Time.time < 2)
            ball.transform.position = trajectory.Lerp(Time.time).ToVector();
    }
}
