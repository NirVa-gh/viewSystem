using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clear : MonoBehaviour
{
    public void Update()
    {
        if (transform.childCount > 1)
        {
            // Удаляем все дочерние объекты, кроме последнего
            for (int i = 0; i < transform.childCount - 1; i++)
            {
                GameObject.Destroy(transform.GetChild(i).gameObject);
            }
        }
    }
}
