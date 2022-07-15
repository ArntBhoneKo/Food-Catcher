using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MenuCurrencyAndHighscore : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI highScore;
    [SerializeField] TextMeshProUGUI currency;

    void Start()
    {
        StartCoroutine(LoadScore());
    }

    IEnumerator LoadScore()
    {
        yield return new WaitForSeconds(0.01f);
        highScore.text = "HighScore " + FindObjectOfType<CurrentGameData>().highScore.ToString();
        currency.text = "Coin " + FindObjectOfType<CurrentGameData>().currency.ToString();
    }

}
