using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BottonMethods : MonoBehaviour
{
    [SerializeField] GameObject objects;
    [SerializeField] GameObject slotParent;
    [SerializeField] GameObject anchor;

    [Header("Force value")]
    [Range(0, 50)]public float m_Thrust = 20f;
    void Start()
    {
        objects = GameObject.Find("Objects");
        slotParent=GameObject.Find("Slots");
        anchor= GameObject.Find("Anchor");
    }
    public void rotate()
    {

    }
    public void destroyObj()
    {
        for (int i = 0; i < objects.transform.GetChild(0).childCount; ++i)
        {
            objects.transform.GetChild(0).GetChild(i).GetComponent<Rigidbody>().isKinematic = false;
            objects.transform.GetChild(0).GetChild(i).GetComponent<Rigidbody>().AddForce(new Vector3(Random.Range(-1, 1), 1, Random.Range(-1, 1)) * m_Thrust, ForceMode.Impulse);
        }  
    }
    public void resetObj()
    {
        foreach(Transform slot in slotParent.transform)
            {
                if (slot.GetComponent<Slot>().ActiveSlot == true)
                {
                    var Clone = Instantiate(slot.GetComponent<Slot>().item.itemPrefab, anchor.transform.position,Quaternion.identity);
                    Clone.transform.SetParent(objects.transform);
                }
            }
    }
}
