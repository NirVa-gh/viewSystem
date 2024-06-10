using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class Hoverable : MonoBehaviour
{
    private void OnMouseEnter()
    {
        UIManager.SetOnHoverText(gameObject.transform.GetChild(0).GetComponent<TMP_Text>().text.ToString());
    }

    private void OnMouseExit()
    {
        UIManager.OffOnHoverText();
    }
    /*public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("OnPointerDown");
        gameObject.GetComponent<MeshRenderer>().enabled = false;

    }
    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("OnPointerUp");
        gameObject.GetComponent<MeshRenderer>().enabled = true;
    }*/
    void OnMouseDown()
    {
        Debug.Log("OnPointerDown");
        gameObject.GetComponent<MeshRenderer>().enabled = false;

    }
        void OnMouseUp()
    {
        Debug.Log("OnPointerUP");
        gameObject.GetComponent<MeshRenderer>().enabled = true;

    }
    
}
