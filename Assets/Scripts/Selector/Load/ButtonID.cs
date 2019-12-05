using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonID : MonoBehaviour
{
    public int ID;
    private GameObject monitor;
    public string name;

    private void Start()
    {
        monitor = GameObject.FindGameObjectWithTag("MonitorLoad");
    }

    public void pressButton() {
        monitor.GetComponent<LoadCaseScript>().pressButton(ID);
    }
}
