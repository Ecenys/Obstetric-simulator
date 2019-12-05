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
        text = GetComponent<EncryptorScript>().Encriptar(text); //encriptación de xml

        if (textfield.text != "" || string.IsNullOrEmpty(textfield.text))
            Debug.Log("texto vacio, escriba algo");
        else
        {
            string path = "Casos\\" + textfield.text + ".case";
            GameObject.FindWithTag("God").GetComponent<ReaderWriter>().WriteString(path, text);

            //StreamWriter fichero; //Clase que representa un fichero
            //fichero = File.CreateText(path); //Creamos un fichero
            //fichero.WriteLine(text); // Lo mismo que cuando escribimos por consola
            //fichero.Close(); // Al cerrar el fichero nos aseguramos que no queda ningún dato por guardar
        }

    }
}
