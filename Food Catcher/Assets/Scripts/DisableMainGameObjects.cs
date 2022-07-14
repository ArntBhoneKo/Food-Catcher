using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableMainGameObjects : MonoBehaviour
{
    GameObject obj;
    private void Start() 
    {
        int numMainGameObject = FindObjectsOfType<MainGameObject>().Length;
        
        if (numMainGameObject > 0)
        {
            obj = GameObject.Find("MainGameObjects");
            Destroy(obj);
        }
    }
}
