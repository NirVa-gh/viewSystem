using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class Slot : MonoBehaviour
{
    [SerializeField]
    public ItemScriptableObject item;
    [SerializeField]
    public bool ActiveSlot;

    void Awake()
    {
        gameObject.GetComponent<Image>().sprite = item.icon;
    }

}
