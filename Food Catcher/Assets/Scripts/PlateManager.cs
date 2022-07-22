using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateManager : MonoBehaviour
{
    public Sprite[] plates;
    public int[] plateCost;
    public SpriteRenderer spriteRenderer;

    private void Awake() 
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    private void Start() 
    {
        UpdatePlate();
    }

    private void Update() 
    {
        ChangePlate(FindObjectOfType<CurrentGameData>().currentPlate);
    }

    public void ChangePlate(int number)
    {
        spriteRenderer.sprite = plates[number]; 
    }

    public void UpdatePlate()
    {
        FindObjectOfType<CurrentGameData>().currentPlate = FindObjectOfType<CurrentGameData>().selectedPlate;
    }

}
