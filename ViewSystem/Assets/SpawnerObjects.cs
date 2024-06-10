using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnerObjects : MainArrayObjects
{
    [Tooltip("Reference to Objects")]
    [SerializeField]
    public Transform Objects;
    private bool _isDone = false;
    public void FixedUpdate()
    {
        if (gameObject.GetComponent<Slot>().ActiveSlot == true)
        {
            if (!_isDone) 
            {
                var Clone = Instantiate(gameObject.GetComponent<Slot>().item.itemPrefab, _anchor.position,Quaternion.identity);
                Clone.transform.SetParent(Objects);
                _isDone = true;
            }
        }
        else
        {
             _isDone = false;
        } 
    }

}
