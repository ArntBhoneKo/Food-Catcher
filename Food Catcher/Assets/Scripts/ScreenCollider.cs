using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenCollider : MonoBehaviour
{
     void Start()
     {
        GenerateCollidersAcrossScreen();
     }
 
 
    void GenerateCollidersAcrossScreen()
    {
     Vector2 lDCorner = GetComponent<Camera>().ViewportToWorldPoint(new Vector3(0, 0f, GetComponent<Camera>().nearClipPlane));
     Vector2 rUCorner = GetComponent<Camera>().ViewportToWorldPoint(new Vector3(1f, 1f, GetComponent<Camera>().nearClipPlane));
     Vector2[] colliderpoints;

    EdgeCollider2D leftEdge = new GameObject("leftEdge").AddComponent<EdgeCollider2D>();
    colliderpoints = leftEdge.points;
    colliderpoints[0] = new Vector2(lDCorner.x, lDCorner.y);
    colliderpoints[1] = new Vector2(lDCorner.x, rUCorner.y);
    leftEdge.points = colliderpoints;

    EdgeCollider2D rightEdge = new GameObject("rightEdge").AddComponent<EdgeCollider2D>();

    colliderpoints = rightEdge.points;
    colliderpoints[0] = new Vector2(rUCorner.x, rUCorner.y);
    colliderpoints[1] = new Vector2(rUCorner.x, lDCorner.y);
    rightEdge.points = colliderpoints;
}
}
