using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    bool heart1;
    bool heart2;
    bool heart3;
    [SerializeField] GameObject heartImg1;
    [SerializeField] GameObject heartImg2;
    [SerializeField] GameObject heartImg3;
    [SerializeField] TextMeshProUGUI scoreText;
    public TextMeshProUGUI currentTimeText;
    [SerializeField] GameObject sadFace;
    [SerializeField] GameObject loseScreen;
    [SerializeField] GameObject winScreen;

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

    public void LoseScreen(bool lose)
    {
        loseScreen.SetActive(lose);
    }

    public void WinScreen(bool win)
    {
        winScreen.SetActive(win);
    }
}
