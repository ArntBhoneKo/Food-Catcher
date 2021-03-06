using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [Header("Ingame UI")]
    bool heart1;
    bool heart2;
    bool heart3;
    [SerializeField] GameObject heartImg1;
    [SerializeField] GameObject heartImg2;
    [SerializeField] GameObject heartImg3;
    [SerializeField] TextMeshProUGUI scoreText;
    public TextMeshProUGUI currentTimeText;

    [Header("Faces")]
    [SerializeField] GameObject sadFace;
    [SerializeField] GameObject angryFace;

    [Header("Win Lose")]
    [SerializeField] GameObject winScreen;
    [SerializeField] TextMeshProUGUI winScore;
    [SerializeField] GameObject loseScreen;
    [SerializeField] TextMeshProUGUI loseScore;
    [SerializeField] GameObject currentScoreScreen;
    [SerializeField] TextMeshProUGUI highScore;
    [SerializeField] TextMeshProUGUI currency;

    void Start() 
    {
        heart1 = true;
        heart2 = true;
        heart3 = true;
        heartImg1.SetActive(true);
        heartImg2.SetActive(true);
        heartImg3.SetActive(true);
    }

    public void UpdateHeart()
    {
        if(heart1 && heart2 && heart3)
        {
            heartImg1.SetActive(false);
            heart1 = false;
            return;
        }

        if(!heart1 && heart2 && heart3)
        {
            heartImg2.SetActive(false);
            heart2 = false;
            return;
        }
        
        if(!heart1 && !heart2 && heart3)
        {
            heartImg3.SetActive(false);
            heart3 = false;
            return;
        }
    }

    public void ResetHeart()
    {
        heart1 = true;
        heart2 = true;
        heart3 = true;
        heartImg1.SetActive(true);
        heartImg2.SetActive(true);
        heartImg3.SetActive(true);
    }

    public void UpdateScore(int mark)
    {
        scoreText.text = mark.ToString();
    }

    public void MakeSadFace(bool sad)
    {
        sadFace.SetActive(sad);
    }

    public void MakeAngryFace(bool angry)
    {
        angryFace.SetActive(angry);
    }

    public void WinScreen(bool win)
    {
        winScreen.SetActive(win);
        CurrentScore(win);
        winScore.text = "You Got " + FindObjectOfType<GameManager>().score.ToString();
    }

    public void LoseScreen(bool lose)
    {
        loseScreen.SetActive(lose);
        CurrentScore(lose);
        loseScore.text = "You Got " + Mathf.Round(FindObjectOfType<GameManager>().score * 0.75f).ToString();
    }

    public void CurrentScore(bool show)
    {
        currentScoreScreen.SetActive(show);
        highScore.text = "HighScore " + FindObjectOfType<CurrentGameData>().highScore.ToString();
        currency.text = FindObjectOfType<CurrentGameData>().currency.ToString();
    }
}
