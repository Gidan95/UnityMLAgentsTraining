using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBoxCollider : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Camera camera = GetComponent<Camera>();
        //BoxCollider2D colliderBox = GetComponent<BoxCollider2D>();
        float sizeY = camera.orthographicSize * 2;
        float ratio = (float)Screen.width / (float)Screen.height;
        float sizeX = sizeY * ratio;
        //colliderBox.size = new Vector2(sizeX, sizeY);
        EdgeCollider2D collider = GetComponent<EdgeCollider2D>();
        List<Vector2> points = new List<Vector2>();
        points.Add(new Vector2(-sizeX * 0.99f / 2, -sizeY *0.99f / 2));
        points.Add(new Vector2(-sizeX * 0.99f / 2, sizeY *0.99f / 2));
        points.Add(new Vector2(sizeX * 0.99f / 2, sizeY * 0.99f / 2));
        points.Add(new Vector2(sizeX * 0.99f / 2, -sizeY * 0.99f / 2));
        points.Add(new Vector2(-sizeX * 0.99f / 2, -sizeY * 0.99f / 2));
        collider.SetPoints(points);
    }
}
