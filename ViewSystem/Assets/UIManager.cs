using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private static TextMeshProUGUI OnHoverText;
    private bool turn;

    void Start()
    {
        OnHoverText = GameObject.Find("Canvas/OnHoverText").GetComponent<TextMeshProUGUI>();
    }

    public static void SetOnHoverText(string descriptionText)
    {
        OnHoverText.text = descriptionText;
    }

    public static void OffOnHoverText()
    {
        OnHoverText.text = "";
    }
    public void TurnOnOff()
    {
        turn = !turn;
        OnHoverText.gameObject.SetActive(turn);
        if (turn)
        {
            gameObject.GetComponent<Image>().color = new Color(0.6431373f, 0.8313726f, 0.8f, 1f);
        }
        else
        {
            gameObject.GetComponent<Image>().color = new Color(0.6431373f, 0.8313726f, 0.8f, 0.75f);
        }
         
    }
    
}
