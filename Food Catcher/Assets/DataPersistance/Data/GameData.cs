using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    private const int V = 2;
    public int currency;
    public int highScore;
    public bool[] plateOwn;
    public int selectedPlate;

    public GameData()
    {
        this.currency = 0;
        this.highScore = 0;
        this.plateOwn = new bool[V];
        this.plateOwn[0] = true;
        this.selectedPlate = 0;
    }
}
