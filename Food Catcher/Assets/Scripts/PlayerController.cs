using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody2D rbp;
    private Vector3 playerPos;
    [SerializeField] GameManager manager;

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
            if(!manager.gameOver)
            {
                float mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
            playerPos = this.transform.position;
            rbp.velocity = new Vector2((mousePos - playerPos.x) * moveSpeed, 0);
            Debug.Log(mousePos);
            }
        }
        else
        {
            rbp.velocity = new Vector2(0, 0);
        }

    }
}