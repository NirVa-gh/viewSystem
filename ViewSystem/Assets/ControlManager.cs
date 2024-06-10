using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class ControlManager : MainArrayObjects
{
    [Tooltip("Reference to slots")]
    [SerializeField] 
    public Transform slotParent;
    [SerializeField] 
    private Color selectedColor;
    [SerializeField] 
    private Color nonSelectedColor;

    private int _currentSlotID = 0;


    void Update()
    {
        float mw = Input.GetAxis("Mouse ScrollWheel");
      
        if (mw > 0.1)
        {
            slotParent.GetChild(_currentSlotID).GetChild(0).GetComponent<Image>().color = nonSelectedColor;
            slotParent.GetChild(_currentSlotID).GetComponent<Slot>().ActiveSlot = false;
            if (_currentSlotID >= slotParent.childCount - 1)
            {
                _currentSlotID = 0;
                //Debug.Log(_currentSlotID);
            }
            else
            {
                _currentSlotID++;
                //Debug.Log(_currentSlotID);
            }
            slotParent.GetChild(_currentSlotID).GetChild(0).GetComponent<Image>().color = selectedColor;
            slotParent.GetChild(_currentSlotID).GetComponent<Slot>().ActiveSlot = true;            
        }
       
        if (mw < -0.1)
        {
            slotParent.GetChild(_currentSlotID).GetChild(0).GetComponent<Image>().color = nonSelectedColor;
            slotParent.GetChild(_currentSlotID).GetComponent<Slot>().ActiveSlot = false;
            if (_currentSlotID <= 0)
            {
                _currentSlotID = slotParent.childCount - 1;
                //Debug.Log(_currentSlotID);
            }
            else
            {
                _currentSlotID--;
                //Debug.Log(_currentSlotID);
            }
            slotParent.GetChild(_currentSlotID).GetChild(0).GetComponent<Image>().color = selectedColor;
            slotParent.GetChild(_currentSlotID).GetComponent<Slot>().ActiveSlot = true;
        }
        for (int i = 0; i < slotParent.childCount; i++)
        {
            if (Input.GetKeyDown((i + 1).ToString()))
            {
                if(_currentSlotID == i)
                {
                    if (slotParent.GetChild(_currentSlotID).GetChild(0).GetComponent<Image>().color == nonSelectedColor)
                    {
                        slotParent.GetChild(_currentSlotID).GetChild(0).GetComponent<Image>().color = selectedColor;
                        slotParent.GetChild(_currentSlotID).GetComponent<Slot>().ActiveSlot = true;
                    }
                    else
                    {
                        slotParent.GetChild(_currentSlotID).GetChild(0).GetComponent<Image>().color = nonSelectedColor;
                        slotParent.GetChild(_currentSlotID).GetComponent<Slot>().ActiveSlot = false;
                    }
                }
                else
                {
                    slotParent.GetChild(_currentSlotID).GetChild(0).GetComponent<Image>().color = nonSelectedColor;
                    slotParent.GetChild(_currentSlotID).GetComponent<Slot>().ActiveSlot = false;
                    _currentSlotID = i;
                    slotParent.GetChild(_currentSlotID).GetChild(0).GetComponent<Image>().color = selectedColor;
                    slotParent.GetChild(_currentSlotID).GetComponent<Slot>().ActiveSlot = true;
                }
            }
        }

     
            
       
    }
}


