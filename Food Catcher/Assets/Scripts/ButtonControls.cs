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
        SceneManager.LoadScene(1);
    }

    public void OpenShop()
    {
        SceneManager.LoadScene(2);
    }

    public void CloseOther()
    {
        SceneManager.LoadScene(0);
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
        yield return new WaitForSecondsRealtime(2);
        SceneManager.LoadScene(level); 
    }
}
