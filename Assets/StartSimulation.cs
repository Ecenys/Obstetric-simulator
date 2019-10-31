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
        text = GetComponent<EncryptorScript>().Encriptar(text); //encriptación de xml
        File.Create("simulation.conf");
        TextWriter tw = new StreamWriter("simulation.conf");
        tw.WriteLine(text);
        tw.Close();

        //Emepezar simulacion
        SceneManager.LoadScene("Main");
    }
}
