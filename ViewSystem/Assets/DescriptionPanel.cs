using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
namespace UIWidgets
{
    public class DescriptionPanel : UIWidget
    {
        [SerializeField]
        Transform parentSlots;
        [SerializeField]
        TMP_Text DescriptionText;
        [SerializeField]
        Transform Description;

        void FixedUpdate()
        {
            foreach(Transform slot in parentSlots)
            {
                if (slot.GetComponent<Slot>().ActiveSlot == true)
                {
                    //Debug.Log(slot.GetComponent<Slot>().item.itemDescription);
                    DescriptionText.text = slot.GetComponent<Slot>().item.itemDescription;

                }
            }
        }

    }
}

