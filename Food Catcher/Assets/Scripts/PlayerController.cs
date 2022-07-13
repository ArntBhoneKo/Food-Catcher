using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody2D rbp;
    private Vector3 playerPos;

    void Start() 
    {
        rbp = this.GetComponent<Rigidbody2D>();
    }

    private void Update() 
    {
        TouchMove();
    }

    void TouchMove()
    {

        if(Input.GetMouseButton(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            playerPos = this.transform.position;
            rbp.velocity = new Vector2((mousePos.x - playerPos.x) * moveSpeed, 0);
        }
        else
        {
            rbp.velocity = new Vector2(0, 0);
        }
        

    }
}