using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentGameData : MonoBehaviour, IDataPersistence
{
    public int highScore = 0;
    public int currency = 0;
    public int currentPlate = 0;
    public int selectedPlate = 0;
    public bool[] plateOwn;

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
        this.plateOwn = data.plateOwn;
        this.selectedPlate = data.selectedPlate;
    }

    public void SaveData(ref GameData data)
    {
        data.currency = this.currency;
        data.highScore = this.highScore;
        data.plateOwn = this.plateOwn;
        data.selectedPlate = this.selectedPlate;
    }

    public bool BuyPlate(int amount)
    {
        if(currency > amount)
        {
            currency -= amount;
            plateOwn[currentPlate] = true;
            DataPersistenceManager.instance.SaveGame();

            return true;
        }
        else
        {
            return false;
        }
    }
}

