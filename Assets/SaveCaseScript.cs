using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class SaveCaseScript : MonoBehaviour
{
    public Text prueba;
    public InputField textfield;
    public GameObject Monitor;
    public void SaveCase()
    {
        string text = Monitor.GetComponent<MonitorScript>().CreateXML(textfield.text);//Creacion de xml
        //text = GetComponent<EncryptorScript>().Encriptar(text); //encriptación de xml

        Debug.Log(textfield.text);

        StreamWriter fichero; //Clase que representa un fichero
        fichero = File.CreateText("Casos\\"+ textfield.text + ".case"); //Creamos un fichero
        fichero.WriteLine(text); // Lo mismo que cuando escribimos por consola
        fichero.Close(); // Al cerrar el fichero nos aseguramos que no queda ningún dato por guardar
    }
}
