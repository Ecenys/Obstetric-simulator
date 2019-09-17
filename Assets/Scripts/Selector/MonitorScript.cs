using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonitorScript : MonoBehaviour
{
    public string Dilatacion;
    public string Borramiento;
    public string Consistencia;
    public string Posicion;
    public string Plano;
    public string Indice;
    public string Madre;

    // Start is called before the first frame update
    void Start()
    {
        Dilatacion = "";
        Borramiento = "";
        Consistencia = "";
        Posicion = "";
        Plano = "";
        Indice = "";
        Madre = "";
    }

    //public void Set(string dilatacion, string borramiento, string consistencia, string posicion, string plano, string indice, string madre)
    //{
    //    this.dilatacion = dilatacion;
    //    this.borramiento = borramiento; 
    //    this.consistencia =  consistencia;
    //    this.posicion = posicion;
    //    this.plano = plano;
    //    this.indice = indice;
    //    this.madre = madre;
    //}
}
