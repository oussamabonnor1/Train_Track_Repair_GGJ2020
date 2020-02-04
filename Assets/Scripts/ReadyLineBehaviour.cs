using System.Collections.Generic;
using UnityEngine;

public class ReadyLineBehaviour : MonoBehaviour
{
    LineRenderer line;
    EdgeCollider2D edgeCollider;
    List<Vector2> points;

    // Start is called before the first frame update
    void Start()
    {
        points = new List<Vector2>();
        line = GetComponent<LineRenderer>();
        edgeCollider = gameObject.AddComponent<EdgeCollider2D>();
        for (int i = 0; i < line.positionCount; i++)
        {
            points.Add(line.GetPosition(i));
        }
        edgeCollider.points = points.ToArray();
        edgeCollider.usedByEffector = true;
    }
}
