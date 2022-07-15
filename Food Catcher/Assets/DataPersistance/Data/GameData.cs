using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    public int currency;
    public int highScore;

    public GameData()
    {
        this.currency = 0;
        this.highScore = 0;
    }
}
