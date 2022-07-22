using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonControls : MonoBehaviour
{
    public GameObject setting;
    public GameObject mainMenu;

    public void OpenLevelMenu()
    {
        StartCoroutine(LoadLevelFromMenu(1));
    }

    public void OpenShop()
    {
        StartCoroutine(LoadLevelFromMenu(2));
    }

    public void CloseOther()
    {
        StartCoroutine(LoadLevelFromMenu(0));
    }

    public void OpenSettingMenu()
    {
        mainMenu.SetActive(false);
        setting.SetActive(true);
    }

    public void CloseSettingMenu()
    {
        setting.SetActive(false);
        mainMenu.SetActive(true);
    }

    public void QuitGame()
    {
        StartCoroutine(ExitGame());
    }

    IEnumerator ExitGame()
    {
        yield return new WaitForSecondsRealtime(1.5f);
        Application.Quit();
    }

    public void Startlvl1()
    {
        StartCoroutine(LoadLevelFromMenu(3));
    }

    public void Startlvl2()
    {
        StartCoroutine(LoadLevelFromMenu(4));
    }

    public void Startlvl3()
    {
        StartCoroutine(LoadLevelFromMenu(5));
    }

    IEnumerator LoadLevelFromMenu(int level)
    {
        yield return new WaitForSecondsRealtime(1);
        SceneManager.LoadScene(level); 
    }

    public void NextPlate()
    {
        if((FindObjectOfType<CurrentGameData>().currentPlate + 1) < FindObjectOfType<PlateManager>().plates.Length)
        {
            FindObjectOfType<CurrentGameData>().currentPlate++;
        }
        else
        {
            FindObjectOfType<CurrentGameData>().currentPlate = 0;
        }

        FindObjectOfType<ShopUIManager>().CheckOwnPlate();
    }

    public void PervPlate()
    {
        if(FindObjectOfType<CurrentGameData>().currentPlate != 0)
        {
            FindObjectOfType<CurrentGameData>().currentPlate--;
        }
        else
        {
            FindObjectOfType<CurrentGameData>().currentPlate = FindObjectOfType<PlateManager>().plates.Length - 1;
        }

        FindObjectOfType<ShopUIManager>().CheckOwnPlate();
    }

    public void BuyPlate()
    {
        bool bought = FindObjectOfType<CurrentGameData>().BuyPlate(FindObjectOfType<PlateManager>().plateCost[FindObjectOfType<CurrentGameData>().currentPlate]);

        if(!bought)
        {
            FindObjectOfType<ShopUIManager>().NeedMoreMoney();
        }
        FindObjectOfType<ShopUIManager>().CheckOwnPlate();
    }

    public void SelectPlate()
    {
        FindObjectOfType<CurrentGameData>().selectedPlate = FindObjectOfType<CurrentGameData>().currentPlate;
        FindObjectOfType<ShopUIManager>().CheckOwnPlate();
    }
}
