using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IndiceScript : MonoBehaviour
{
    public MonitorScript monitor;
    public Dropdown dilatacion;
    public Dropdown borramiento;
    public Dropdown consistencia;
    public Dropdown posicion;
    public Dropdown plano;
    public string madre;

    private int indice;

    private Text textField;

    // Start is called before the first frame update
    void Start()
    {
        textField = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        indice = dilatacion.value + borramiento.value + consistencia.value + posicion.value + plano.value;
        textField.text = "Indice de Bishop: " + indice;
        
    }

    public void Siguiente()
    {
        if (dilatacion.value == 0)
            monitor.Dilatacion = "0";
        else if (dilatacion.value == 1)
                monitor.Dilatacion = "1-2";
        else if (dilatacion.value == 2)
            monitor.Dilatacion = "3-4";
        else
            monitor.Dilatacion = "+5";

        if (consistencia.value == 0)
            monitor.Consistencia= "Firme";
        else if (consistencia.value == 1)
            monitor.Consistencia = "Media";
        else
            monitor.Consistencia = "Blanda";

        if (posicion.value == 0)
            monitor.Posicion = "Posterior";
        else if (posicion.value == 1)
            monitor.Posicion = "Media";
        else
            monitor.Posicion = "Anterior";

        if (borramiento.value == 0)
            monitor.Borramiento = "<30";
        else if (posicion.value == 1)
            monitor.Borramiento = "40-50";
        else if (posicion.value == 2)
            monitor.Borramiento = "60-70";
        else
            monitor.Borramiento = ">80";

        monitor.Indice = "" + indice;

        monitor.Madre = "Primipara";
    }
}
