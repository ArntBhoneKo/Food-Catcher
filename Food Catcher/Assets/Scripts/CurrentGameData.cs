using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentGameData : MonoBehaviour, IDataPersistence
{
    public int highScore = 0;
    public int currency = 0;

    private void Awake() 
    {
        int numCurrentGameData = FindObjectsOfType<CurrentGameData>().Length;
        if (numCurrentGameData > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public void ScoreCheck(int newScore)
    {
        if(newScore > highScore)
        {
            highScore = newScore;
        }

        currency += newScore;

        DataPersistenceManager.instance.SaveGame();
    }

    public void LoadData(GameData data)
    {
        this.currency = data.currency;
        this.highScore = data.highScore;
    }

    public void SaveData(ref GameData data)
    {
        data.currency = this.currency;
        data.highScore = this.highScore;
    }

    public void TakeCurrency(int amount)
    {
        currency -= amount;
        DataPersistenceManager.instance.SaveGame();
    }
}

