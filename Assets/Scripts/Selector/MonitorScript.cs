using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class MonitorScript : MonoBehaviour
{
    //Valores de Canvas Madre
    public string Dilatacion;
    public string Borramiento;
    public string Consistencia;
    public string Posicion;
    public string Plano;
    public string Indice;
    public string Madre;

    //Valores de Canvas Bebe
    public string Tipo;
    public string Orientacion;

    private static int ITipo;
    private static int IOrientacion;



    // Start is called before the first frame update
    void Start()
    {
        //asignación de valores predeterminados
        Dilatacion = "0";
        Borramiento = "30";
        Consistencia = "Firme";
        Posicion = "Posterior";
        Plano = "SES";
        Indice = "0";
        Madre = "primipara";
        Tipo = "1";
        Orientacion = "DA";

        ITipo = 1;
        IOrientacion = 90;
    }

    private void Update()
    {
        
    }

    public string CreateXML(string Nombre)
    {
        return @"<Propiedades>
                      <Nombre>" + Nombre + @"</Nombre>
                      <Utero>
                          <Dilatacion>" + Dilatacion + @"</Dilatacion>
                          <Borramiento>" + Borramiento + @"</Borramiento>
                          <Consistencia>" + Consistencia + @"</Consistencia>
                          <Posicion>" + Posicion + @"</Posicion>
                          <Plano>" + Plano+ @"</Plano>
                          <Madre>" + Madre + @"</Madre>
                       </Utero>
                       <Bebe>
                          <Tipo>" + Tipo + @"</Tipo>
                          <Orientacion> "+ Orientacion + @"</Orientacion>
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
        catch(Exception) { Debug.Log("Archivo corrupto"); }
    }
    public void SetTipo(string tipo)
    {
        Tipo = tipo;
    }

    public void SetOrientacion(string orientacion)
    {
        Orientacion = orientacion;
    }

    public void SetTipo(int tipo) {
        ITipo = tipo;
    }

    public void SetOrientacion(int orientacion)
    {
        IOrientacion = orientacion;
    }

    public int GetTipo() {
        return ITipo;
    }
    
    public int GetOrientacion()
    {
        return IOrientacion;
    }
}
