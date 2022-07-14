using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameObject : MonoBehaviour
{
    void Awake()
    {
        int numGameManagers = FindObjectsOfType<GameManager>().Length;
        if (numGameManagers > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}
