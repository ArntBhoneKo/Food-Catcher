using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

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
        if(FindObjectOfType<GameManager>().gameOver)
        {
            return;
        }

        Vector2 touchPosition = Touchscreen.current.primaryTouch.position.ReadValue();
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(touchPosition);

        playerPos = rbp.transform.position;
        rbp.velocity = new Vector2((worldPosition.x - playerPos.x) * moveSpeed, 0);
        
    }

}