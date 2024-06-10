using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
public enum ItemType {Default, Instrument, component }
[CreateAssetMenu(fileName ="New object",menuName ="New object/Items")]
public class ItemScriptableObject : ScriptableObject
{  
    [Header("Main Characteristics")]
    [Tooltip("Name of object")]
    [SerializeField]
    public string ItemName = "Default";

    [Tooltip("Select object type")]
    [SerializeField]
    public ItemType itemType = ItemType.Default;

    [Tooltip("Select object type")]
    [SerializeField]
    public Sprite icon;

    [Tooltip("Item Description")]
    [SerializeField]
    public string itemDescription;

    [Tooltip("Item prefab")]
    [SerializeField]
    public GameObject itemPrefab;

}
