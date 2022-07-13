using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadObjects : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.gameObject.tag == "Player")
        {
            if (!FindObjectOfType<GameManager>().gameOver)
            {
                FindObjectOfType<GameManager>().ProcessPlayerLife();
            }
            Destroy(this.gameObject);
        }
    }
}
