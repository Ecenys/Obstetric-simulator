using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSimulation : MonoBehaviour
{
    public void LoadSimulation() {
        //Paso de parametros
        string text = GameObject.FindWithTag("God").GetComponent<MonitorScript>().CreateXML("simulation.conf");//Creacion de xml
        text = GameObject.FindWithTag("God").GetComponent<EncryptorScript>().Encriptar(text); //encriptación de xml
        //File.Create("simulation.conf");
        //TextWriter tw = new StreamWriter("simulation.conf");
        //tw.WriteLine(text);
        //tw.Close();
        File.WriteAllText(@"simulation.conf", text);
        //Emepezar simulacion
        SceneManager.LoadScene("Main");
    }

    public void CargarCaso()
    {
        GameObject monitor = GameObject.FindGameObjectWithTag("MonitorLoad");
        string direccion = monitor.GetComponent<LoadCaseScript>().getName();
        //lectura
        StreamReader reader = new StreamReader(@"Casos\"+ direccion +"*.txt");
        string text = reader.ReadToEnd();
        reader.Close();
        //simulación
        text = GameObject.FindWithTag("God").GetComponent<EncryptorScript>().Encriptar(text); //encriptación de xml
        File.WriteAllText(@"simulation.conf", text);
        SceneManager.LoadScene("Main");
    }
}
