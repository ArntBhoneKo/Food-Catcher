using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameObject : MonoBehaviour
{
    void Awake()
    {
        int numMainGameObject = FindObjectsOfType<MainGameObject>().Length;
        if (numMainGameObject > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}
