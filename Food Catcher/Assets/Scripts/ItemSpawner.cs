using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public GameObject[] theFoods;
    GameObject foods;
    private Vector2 screenBounds;

    [Space(3)]
    public float theCountdown = 3;
    
    // Start is called before the first frame update
    void Start()
    {
        foods = theFoods [Random.Range (0, theFoods.Length)];
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        theCountdown -= Time.deltaTime;
         if(theCountdown <= 0)
         {
            foods = theFoods [Random.Range (0, theFoods.Length)];
            SpawnFoods ();
            theCountdown = Random.Range(0.1f, 1.5f);
         }
    }

    void SpawnFoods()
     {
        GameObject food = Instantiate (foods) as GameObject;

        food.transform.position = new Vector2 (Random.Range(screenBounds.x * 0.9f, -screenBounds.x * 0.9f), screenBounds.y * 2);
     }
}
