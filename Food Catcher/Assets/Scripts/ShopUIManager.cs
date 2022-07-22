using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShopUIManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI price;
    [SerializeField] GameObject buyButton;
    [SerializeField] GameObject selectButton;
    [SerializeField] GameObject cannotBuy;
    [SerializeField] GameObject cannotFace;

    public void CheckOwnPlate()
    {
        if(FindObjectOfType<CurrentGameData>().plateOwn[FindObjectOfType<CurrentGameData>().currentPlate])
        {
            buyButton.SetActive(false);
            selectButton.SetActive(true);

            price.text = "Owned";
            if(FindObjectOfType<CurrentGameData>().currentPlate == FindObjectOfType<CurrentGameData>().selectedPlate)
            {
                price.text = "Selected";
            }
        }
        else
        {
            buyButton.SetActive(true);
            selectButton.SetActive(false);

            price.text = FindObjectOfType<PlateManager>().plateCost[FindObjectOfType<CurrentGameData>().currentPlate].ToString();
        }
    }

    public void NeedMoreMoney()
    {
        StartCoroutine(CannotBuy());
    }

    IEnumerator CannotBuy()
    {
        cannotBuy.SetActive(true);
        cannotFace.SetActive(true);
        yield return new WaitForSecondsRealtime(3);
        cannotBuy.SetActive(false);
        cannotFace.SetActive(false);
    }

}
