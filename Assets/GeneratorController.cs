using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using UnityEngine;

public class GeneratorController : MonoBehaviour
{
    //Valores de Canvas Madre
    private string Dilatacion;
    private string Borramiento;
    private string Consistencia;
    private string Posicion;
    private string Plano;
    private string Indice;
    private string Madre;

    //Valores de Canvas Bebe
    private string Tipo;
    private string Orientacion;

    private static int ITipo;
    private static int IOrientacion;

    ReaderWriter rw;
    string xml;
    // Start is called before the first frame update
    void Start()
    {

        rw = GetComponent<ReaderWriter>();
        xml = rw.ReadString("simulation.conf");
        File.Delete("simulation.conf");
        xml = GetComponent<EncryptorScript>().DesEncriptar(xml);
        ReadXML(xml);

        //Simulacion
        //Donut
        switch (Dilatacion)
        {
            //Modificar tamaño donut
        }
        switch (Borramiento)
        {
            //Modificar anchura donut
        }
        switch (Consistencia)
        {
            //Modificar consistencia
        }
        switch (Posicion)
        {
            //Seleccionar mesh utero
        }
        switch (Plano)
        {
            //Seleccionar plano
        }
        
        //Bebe
        switch (Tipo)
        {
            //seleccionar modelo bebe
        }
        switch (Plano)
        {
            //rotar bebe
        }

    }

    // Update is called once per frame
    public void ReadXML(string Xml)
    {
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
        catch (System.Exception ex) { Debug.Log("Archivo corrupto"); }
    }
}