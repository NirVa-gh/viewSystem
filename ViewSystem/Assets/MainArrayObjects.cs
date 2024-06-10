using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainArrayObjects : MonoBehaviour
{
    [Tooltip("Position to spawn object")]
    [SerializeField] 
    public Transform _anchor;

    [Tooltip("Array all objects")]
    [SerializeField] 
    public GameObject[] objects;
}
