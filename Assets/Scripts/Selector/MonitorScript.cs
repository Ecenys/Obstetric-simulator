﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
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

    public string Tipo;
    public string Orientacion;


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
        Tipo = "";
        Orientacion = "";
    }

    private void Update()
    {
        
    }

    public string CreateXML(string Nombre)
    {
        return @"<Propiedades>
                      <Nombre> " + Nombre + @" </Nombre>
                      <Utero>
                          <Dilatacion> " + Dilatacion + @" </Dilatacion>
                          <Borramiento> " + Borramiento + @" </Borramiento>
                          <Consistencia> " + Consistencia + @" </Consistencia>
                          <Posicion> " + Posicion + @" </Posicion>
                          <Plano> " + Plano+ @" </Plano>
                          <Madre> " + Madre + @" </Madre>
                       </Utero>
                       <Bebe>
                          <Tipo> " + Tipo + @" </Tipo>
                          <Orientacion> " + Orientacion + @" </Orientacion>
                       </Bebe>
                  </Propiedades>";
    }

    public void ReadXML(string Xml) {
        XmlDocument doc = new XmlDocument();
        doc.LoadXml(Xml);
        //doc.Load(new StringReader(Xml));

        try
        {
            //XmlNodeList Nombre = doc.GetElementsByTagName("Nombre");
            //string prueba = Nombre[0].InnerText;
            XmlNodeList Dilatacion = doc.GetElementsByTagName("Dilatacion");
            this.Dilatacion = Dilatacion[0].InnerText;
            XmlNodeList Borramiento = doc.GetElementsByTagName("Borramiento");
            this.Borramiento = Borramiento[0].InnerText;
            XmlNodeList Consistencia = doc.GetElementsByTagName("Consistencia");
            this.Consistencia = Consistencia[0].InnerText;
            XmlNodeList Posicion = doc.GetElementsByTagName("Posicion");
            this.Posicion = Posicion[0].InnerText;
            XmlNodeList Plano = doc.GetElementsByTagName("Plano");
            this.Plano = Plano[0].InnerText;
            XmlNodeList Madre = doc.GetElementsByTagName("Madre");
            this.Madre = Madre[0].InnerText;
            XmlNodeList Tipo = doc.GetElementsByTagName("Tipo");
            this.Tipo = Tipo[0].InnerText;
            XmlNodeList Orientacion = doc.GetElementsByTagName("Orientacion");
            this.Orientacion = Orientacion[0].InnerText;
        }
        catch(Exception ex) { Debug.Log("Archivo corrupto"); }
    }
    public void SetTipo(string tipo)
    {
        Tipo = tipo;
    }

    public void SetOrientacion(string orientacion)
    {
        Orientacion = orientacion;
    }
}
