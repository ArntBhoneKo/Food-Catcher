using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] int playerLives = 3;
    [SerializeField] int score = 0;
    [SerializeField] float loadDelay = 1f;
    
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

    public void ProcessPlayerLife()
    {
        if (playerLives > 1)
        {
            TakeLife();
        }
        else
        {
            ResetLife();
        }
        Debug.Log(playerLives);
    }

    void TakeLife()
    {
        playerLives--;
    }

    void ResetLife()
    {
        playerLives = 3;
        score = 0;
        StartCoroutine(ResetLevel());
    }

    IEnumerator ResetLevel()
    {
        yield return new WaitForSecondsRealtime(loadDelay);
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }

    public void AddToScore(int pointsToAdd)
    {
        score += pointsToAdd;
        Debug.Log(score);
    }
}
