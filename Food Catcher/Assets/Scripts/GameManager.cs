using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] int playerLives = 3;
    [SerializeField] int score = 0;
    [SerializeField] float loadDelay = 1f;
    public bool gameOver = false;
    [SerializeField] UIManager uiManager;
    
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

    void Start() 
    {
        gameOver = false;
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

            //test
            gameOver = true;
        }
    }

    void TakeLife()
    {
        playerLives--;
        uiManager.UpdateHeart();
    }

    void ResetLife()
    {
        uiManager.UpdateHeart();
        playerLives = 3;
        score = 0;
        StartCoroutine(ResetLevel());
    }

    IEnumerator ResetLevel()
    {
        yield return new WaitForSecondsRealtime(loadDelay);
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
        uiManager.ResetHeart();

        //test
        gameOver = false;
    }

    public void AddToScore(int pointsToAdd)
    {
        score += pointsToAdd;
        uiManager.UpdateScore(score);
    }
}
