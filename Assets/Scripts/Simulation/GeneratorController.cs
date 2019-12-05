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

    private float x, z;

    ReaderWriter rw;
    string xml;

    //partes del cuerpo
    public GameObject MeshUtero, MeshUteroAmpliado;
    public GameObject MeshCabeza, MeshFontanelas, Cara, Nalgas, Espalda;
    //public GameObject OrigenAnteriorBebe, OrigenMedioBebe, OrigenPosteriorBebe;
    //public GameObject OrigenAnterior, OrigenMedio, OrigenPosterior;
    public GameObject Cabeza, Cabeza2, CabezaVisual, Donut, Donut0;
    public GameObject HapticScaler;

    //variables internas
    private double consistencia;

    // Start is called before the first frame update
    
        private void Awake()
        {

        rw = GetComponent<ReaderWriter>();
        xml = rw.ReadString("simulation.conf");
        File.Delete("simulation.conf");
        xml = GameObject.FindWithTag("God").GetComponent<EncryptorScript>().DesEncriptar(xml);
        File.WriteAllText(@"prueba.text", xml); //salida de texto a un archivo prueba.text sin codificar, para comprobación de salida, borrar en un futuro
        ReadXML(xml);

        Debug.Log(xml);

        //Simulacion
        //Bebe
        switch (Tipo)
        {
            case ("1"):
            case ("2"):
            case ("3"):
            case ("4"):
            case ("5"):
            case ("6"):
            case ("7"):
                Debug.Log("Cabeza");
                Cabeza.SetActive(true);
                //MeshCabeza.SetActive(true);
                //MeshFontanelas.SetActive(true);
                Nalgas.SetActive(false);
                Espalda.SetActive(false);
                break;
            case ("8"):
                Debug.Log("Nalgas");
                Cabeza.SetActive(false);
                //MeshCabeza.SetActive(false);
                //MeshFontanelas.SetActive(false);
                Nalgas.SetActive(true);
                Espalda.SetActive(false);
                break;
            case ("9"):
                Debug.Log("Espalda");
                Cabeza.SetActive(false);
                //MeshCabeza.SetActive(false);
                //MeshFontanelas.SetActive(false);
                Nalgas.SetActive(false);
                Espalda.SetActive(true);
                break;
            default:
                Debug.LogError("No se ha generado la cabeza");
                break;
        }
        switch (Tipo)
        {
            //seleccionar modelo bebe
            case ("1"):
                Debug.Log("cabeza 1");
                x = 0;
                //Cabeza.transform.localRotation = Quaternion.Euler(-90f, Cabeza.transform.localRotation.y, Cabeza.transform.localRotation.z);
                break;
            case ("2"):
                x = 10f;
                //Cabeza.transform.rotation = Quaternion.Euler(-110f, Cabeza.transform.rotation.y, Cabeza.transform.rotation.z);
                Debug.Log("cabeza 2");
                break;
            case ("3"):
                x = 20f;
                //Cabeza.transform.rotation = Quaternion.Euler(-120f, Cabeza.transform.rotation.y, Cabeza.transform.rotation.z);
                Debug.Log("cabeza 3");
                break;
            case ("4"):
                x = 40f;
                //Cabeza.transform.rotation = Quaternion.Euler(-130f, Cabeza.transform.rotation.y, Cabeza.transform.rotation.z);
                Debug.Log("cabeza 4");
                break;
            case ("5"):
                x = 50f;
                //Cabeza.transform.rotation = Quaternion.Euler(-140f, Cabeza.transform.rotation.y, Cabeza.transform.rotation.z);
                Debug.Log("cabeza 5");
                break;
            case ("6"):
                x = 60f;
                //Cabeza.transform.rotation = Quaternion.Euler(-150f, Cabeza.transform.rotation.y, Cabeza.transform.rotation.z);
                Debug.Log("cabeza 6");
                break;
            case ("7")://oreja
                Cabeza.transform.rotation = Quaternion.Euler(Cabeza.transform.rotation.x, -90, Cabeza.transform.rotation.z);
                Debug.Log("oreja");
                break;
        }
        //seleccionar modelo bebe

        switch (Orientacion)
        {
            case "DA":
                Debug.Log("DA");
                z = 180f;
                //Cabeza.transform.localRotation = Quaternion.Euler(Cabeza.transform.localRotation.x, Cabeza.transform.localRotation.y, 180);
                break;
            case "DIA":
                Debug.Log("DIA");
                z = 135f;
                //Cabeza.transform.localRotation = Quaternion.Euler(Cabeza.transform.localRotation.x, Cabeza.transform.localRotation.y, 135);
                break;
            case "DITDerecha":
                Debug.Log("DITDerecha");
                z = 90f;
                //Cabeza.transform.localRotation = Quaternion.Euler(Cabeza.transform.localRotation.x, Cabeza.transform.localRotation.y, 90);
                break;
            case "DIP":
                z = 45f;
                Debug.Log("DIP");
                //Cabeza.transform.localRotation = Quaternion.Euler(Cabeza.transform.localRotation.x, Cabeza.transform.localRotation.y, 45);
                break;
            case "DP":
                Debug.Log("DP");
                z = 0f;
                //Cabeza.transform.localRotation = Quaternion.Euler(Cabeza.transform.localRotation.x, Cabeza.transform.localRotation.y, 0);
                break;
            case "DDP":
                Debug.Log("DDP");
                z = -45f;
                //Cabeza.transform.localRotation = Quaternion.Euler(Cabeza.transform.localRotation.x, Cabeza.transform.localRotation.y, -45);
                break;
            case "DITIzquierda":
                Debug.Log("DITIzquierda");
                z = -90f;
                //Cabeza.transform.localRotation = Quaternion.Euler(Cabeza.transform.localRotation.x, Cabeza.transform.localRotation.y, -90);
                break;
            case "DDA":
                Debug.Log("DDA");
                z = -135f;
                //Cabeza.transform.localRotation = Quaternion.Euler(Cabeza.transform.localRotation.x, Cabeza.transform.localRotation.y, -135);
                break;
            default:
                Debug.Log("No he encontrado nada, tengo la orgientación: " + Orientacion);
                break;

        }
        Cabeza.transform.localRotation = Quaternion.Euler(Cabeza.transform.localRotation.x + x, Cabeza.transform.localRotation.y, Cabeza.transform.localRotation.z);

        Cabeza.transform.localRotation=Quaternion.Euler(Cabeza.transform.localRotation.x, Cabeza.transform.localRotation.y, Cabeza.transform.localRotation.z + z);

        //Madre
        switch (Dilatacion)
        {
        //    if (dilatacion.value == 0)
        //    monitor.Dilatacion = "0";
        //else if (dilatacion.value == 1)
        //    monitor.Dilatacion = "1-2";
        //else if (dilatacion.value == 2)
        //    monitor.Dilatacion = "3-4";
        //else
        //    monitor.Dilatacion = "+5";
            case "0":
                Debug.Log("0");
                Donut0.SetActive(true);
                Donut.SetActive(false);
                //Donut.transform.localScale = new Vector3(1f, Donut.transform.localScale.y, 1f);
                break;
            case "1-2":
                Debug.Log("1-2");
                Donut0.SetActive(false);
                Donut.SetActive(true);
                Donut.transform.localScale = new Vector3(60f, Donut.transform.localScale.y, 60f);
                break;
            case "3-4":
                Donut0.SetActive(false);
                Donut.SetActive(true);
                Debug.Log("3-4");
                Donut.transform.localScale = new Vector3(140f, Donut.transform.localScale.y, 140f);
                break;
            case "5":
                Donut0.SetActive(false);
                Donut.SetActive(true);
                Debug.Log("5");
                Donut.transform.localScale = new Vector3(200f, Donut.transform.localScale.y, 200f);
                break;
                //Modificar tamaño donut
                //case "1":
                //    Donut.transform.localScale = new Vector3(0.04f, transform.localScale.y, 0.04f);
                //    break;
                //case "2":
                //    Donut.transform.localScale = new Vector3(0.08f, transform.localScale.y, 0.08f);
                //    break;
                //case "3":
                //    Donut.transform.localScale = new Vector3(0.12f, transform.localScale.y, 0.12f);
                //    break;
                //case "4":
                //    Donut.transform.localScale = new Vector3(0.16f, transform.localScale.y, 0.16f);
                //    break;
                //case "5":
                //    Donut.transform.localScale = new Vector3(0.2f, transform.localScale.y, 0.2f);
                //    break;
                //case "6":
                //    Donut.transform.localScale = new Vector3(0.28f, transform.localScale.y, 0.28f);
                //    break;
                //case "7":
                //    Donut.transform.localScale = new Vector3(0.28f, transform.localScale.y, 0.28f);
                //    break;
                //case "8":
                //    Donut.transform.localScale = new Vector3(0.32f, transform.localScale.y, 0.32f);
                //    break;
                //case "9":
                //    Donut.transform.localScale = new Vector3(0.36f, transform.localScale.y, 0.36f);
                //    break;
                //case "10":
                //    Donut.transform.localScale = new Vector3(0.4f, transform.localScale.y, 0.4f);
                //    break;

        }
        switch (Borramiento)
        {
            case "30":
                Debug.Log("Borramiento 30");
                Donut.transform.localScale = new Vector3(Donut.transform.localScale.x, 60.8f, Donut.transform.localScale.z);
                break;
            case "40-50":
                Debug.Log("Borramiento 40-50");
                Donut.transform.localScale = new Vector3(Donut.transform.localScale.x, 49.4f, Donut.transform.localScale.z);
                break;
            case "60-70":
                Debug.Log("Borramiento 60-70");
                Donut.transform.localScale = new Vector3(Donut.transform.localScale.x, 41.8f, Donut.transform.localScale.z);
                break;
            case "80":
                Debug.Log("Borramiento 80");
                Donut.transform.localScale = new Vector3(Donut.transform.localScale.x, 22.8f, Donut.transform.localScale.z);
                break;

        }
        switch (Consistencia)
        {
            //Modificar consistencia
            case "Firme":
                Debug.Log("Firme");
                consistencia = 0.7;
                break;
            case "Media":
                Debug.Log("Consistencia Media");
                consistencia = 0.2;
                break;
            case "Blanda":
                Debug.Log("Blanda");
                consistencia = 0.05;
                break;
        }
        switch (Posicion)
        {

            //Seleccionar mesh utero
            case "Posterior":
                Debug.Log("Posterior");
                //colocar donut 0.25 -0.65 8.8
                //colocar cabeza .25 -.225 9.414
                //MeshPosterior.SetActive(true);
                //MeshMedio.SetActive(false);
                //MeshAnterior.SetActive(false);
                Donut.transform.localPosition= new Vector3(0.2399997f, -1, 10);
                Donut.transform.rotation = Quaternion.Euler(-48,-180,0);
                break;
            case "Media":
                Debug.Log("Posicion Media");
                //Cabeza.transform.position = new Vector3(0.24f, -0.73f, 9.55f);
                //Cabeza.transform.rotation = Quaternion.Euler(-67.6f, -180, 70);
                //colocar donut 0.25 -1.04 8.65
                //Donut.transform.position = new Vector3(0.23f, 1.9f, 12);
                //Donut.transform.rotation = Quaternion.Euler(-80, -180, 0);
                ////colocar cabeza
                //MeshPosterior.SetActive(false);
                //MeshMedio.SetActive(true);
                //MeshAnterior.SetActive(false);
                Donut.transform.localPosition = new Vector3(0.2399997f, -1, 9.5f);
                Donut.transform.rotation = Quaternion.Euler(-51.7f, 180, 0);
                break;
            case "Anterior":
                Debug.Log("Anterior");
                //colocar donut 0.25,-0.9, 8.2
                //colocar cabeza 0.24 0.015 9.6
                //MeshPosterior.SetActive(false);
                //MeshMedio.SetActive(false);
                //MeshAnterior.SetActive(true);
                Donut.transform.localPosition = new Vector3(0.2399997f, -1, 92f);
                Donut.transform.rotation = Quaternion.Euler(-65, -180, 0);
                break;
        }
        switch (Plano)
        {
            //Medidas para plano Medio
            // SES 0.23, 3.32, 12.31
            // I 0.24f, -0.73f, 9.55f
            // II 0.23 0.56 11.91
            // III .23 -0.65 11.31 rotación -94 -180 0
            //Seleccionar plano
            case "SES":
                Debug.Log("SES");
                Cabeza.transform.position = new Vector3(0.019f, 0.1960816f, 1.193f);
                MeshUtero.SetActive(true);
                MeshUteroAmpliado.SetActive(false);
                break;
            case "I":
                Debug.Log("I");
                Cabeza.transform.position= new Vector3(0.019f, 0.129f, 1.134f);
                MeshUtero.SetActive(true);
                MeshUteroAmpliado.SetActive(false);
                break;
            case "II":
                Debug.Log("II");
                Cabeza.transform.position = new Vector3(0.019f, 0.064f, 1.132f);
                MeshUtero.SetActive(true);
                MeshUteroAmpliado.SetActive(false);
                break;
            case "III":
                Debug.Log("III");
                Cabeza.transform.position = new Vector3(0.032f,0.047f,1.07f);
                MeshUtero.SetActive(false);
                MeshUteroAmpliado.SetActive(true);
                break;
        }

        //Reordeno parentesco
        CabezaVisual.transform.parent = HapticScaler.transform;
        MeshCabeza.transform.parent = HapticScaler.transform;
        MeshFontanelas.transform.parent = HapticScaler.transform;

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
    public double GetConsistencia()
    {
        //se envia a touchableobject para realizar el cambio ahí
        return consistencia;
    }

}




/*
 * XML que recibe
 * if (dilatacion.value == 0)
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
            monitor.Borramiento = "30";
        else if (posicion.value == 1)
            monitor.Borramiento = "40-50";
        else if (posicion.value == 2)
            monitor.Borramiento = "60-70";
        else
            monitor.Borramiento = "80";

        if (plano.value == 0)
            monitor.Plano = "SES";
        else if (posicion.value == 1)
            monitor.Plano = "I";
        else if (posicion.value == 2)
            monitor.Plano = "II";
        else
            monitor.Plano = "III";

        monitor.Indice = "" + indice;

        monitor.Madre = madre;
*/