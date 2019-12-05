using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeController : MonoBehaviour
{
    public GameObject Rotator;

    void Update()
    {
        //Recojo estado en monitor
        int id = GameObject.FindWithTag("God").GetComponent<MonitorScript>().GetTipo();
        int orientacion = GameObject.FindWithTag("God").GetComponent<MonitorScript>().GetOrientacion();
        GetComponent<ToggleScript>().ChangeModel(id);
        Rotator.transform.rotation = Quaternion.Euler(0, 0, orientacion - 90);
    }
}
