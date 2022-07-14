using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] int playerLives = 3;
    public int score = 0;
    [SerializeField] float loadDelay = 1f;
    [SerializeField] float happyTime = 2f;
    public bool gameOver = false;
    [SerializeField] UIManager uiManager;
    [SerializeField] Timer timer;
    bool notSadNow = false;
    bool buttonpressed = false;

    void Start() 
    {
        gameOver = false;
        timer.StartStopwatch(true);
    }

    private void Update() 
    {
        if (timer.currentTime <= 0)
        {
            gameOver = true;

            uiManager.WinScreen(true);
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
            
            gameOver = true;

            uiManager.UpdateHeart();
            timer.StartStopwatch(false);
            uiManager.LoseScreen(true);
        }
    }

    void TakeLife()
    {
        playerLives--;
        uiManager.UpdateHeart();
    }

    public void ResetLife()
    {
        playerLives = 3;
        score = 0;
        StartCoroutine(ResetLevel());
    }

    IEnumerator ResetLevel()
    {
        if (buttonpressed)
            yield break;

        buttonpressed = true;

        yield return new WaitForSecondsRealtime(loadDelay);
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
        uiManager.WinScreen(false);
        uiManager.LoseScreen(false);
        uiManager.UpdateScore(score);
        uiManager.ResetHeart();
        timer.ResetStopwatch();
        timer.StartStopwatch(true);
        gameOver = false;
        buttonpressed = false;
    }

    public void AddToScore(int pointsToAdd)
    {
        score += pointsToAdd;
        uiManager.UpdateScore(score);
        StartCoroutine(HappyTime());
    }

    IEnumerator HappyTime()
    {
        if (notSadNow)
            yield break;
    
        notSadNow = true;
        uiManager.MakeSadFace(false);

        yield return new WaitForSeconds(happyTime);
        uiManager.MakeSadFace(true);
        notSadNow = false;
    }
}
