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

    //partes del cuerpo
    public GameObject MeshAnterior, MeshMedio, MeshPosterior;
    public GameObject Cabeza, Fontanelas, Cara, Nalgas, Espalda;
    public GameObject OrigenAnterior, OrigenMedio, OrigenPosterior;
    public GameObject Donut;

    // Start is called before the first frame update
    void Start()
    {

        rw = GetComponent<ReaderWriter>();
        xml = rw.ReadString("simulation.conf");
        File.Delete("simulation.conf");
        xml = GameObject.FindWithTag("God").GetComponent<EncryptorScript>().DesEncriptar(xml);
        File.WriteAllText(@"prueba.text", xml); //salida de texto a un archivo prueba.text sin codificar, para comprobación de salida, borrar en un futuro
        ReadXML(xml);

        Debug.Log(xml);

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
        Debug.Log("paso por aqui");
        Debug.Log("+"+ Tipo + "+");

        //Bebe
        switch (Tipo)
        {
            //seleccionar modelo bebe
            case ("1"):
            case ("2"):
            case ("3"):
            case ("4"):
            case ("5"):
            case ("6"):
            case ("7"):

                Debug.Log("paso por aqui tambien");
                Cabeza.SetActive(true);
                Fontanelas.SetActive(true);
                Nalgas.SetActive(false);
                Espalda.SetActive(false);
                break;
            case ("8"):
                Cabeza.SetActive(false);
                Fontanelas.SetActive(false);
                Nalgas.SetActive(true);
                Espalda.SetActive(false);
                Debug.Log("8");
                break;
            case ("9"):
                Cabeza.SetActive(false);
                Fontanelas.SetActive(false);
                Nalgas.SetActive(false);
                Espalda.SetActive(true);

                Debug.Log("9");
                break;
            default:
                Debug.Log("no me meto en ningun lado");
                break;
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
        catch (System.Exception) { Debug.Log("Archivo corrupto"); }
    }
}