using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactive : MonoBehaviour
{
    public GameObject item;
    void OnMouseDown()
    {
        item.transform.position = transform.position;
    }
}
