using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragSlot : MonoBehaviour, IPointerDownHandler
{
    private GameObject slotParent;
    void Awake()
    {
        slotParent=GameObject.Find("Slots");
    }
    public void OnPointerDown(PointerEventData eventData)
    { 
        foreach(Transform slot in slotParent.transform)
            {
                slot.GetComponent<Slot>().ActiveSlot = false;
                slot.GetChild(0).GetComponent<Image>().color = new Color(0,0,0); 
            }
        gameObject.GetComponent<Slot>().ActiveSlot = true;
        gameObject.transform.GetChild(0).GetComponent<Image>().color = new Color(255,0,0); 
    }
}
