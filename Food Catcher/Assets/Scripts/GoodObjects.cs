using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodObjects : MonoBehaviour
{
    [SerializeField] int scorePoint = 10;
    private void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.gameObject.tag == "Player")
        {   
            FindObjectOfType<GameManager>().AddToScore(scorePoint);
            Destroy(this.gameObject);
        }
    }
}
