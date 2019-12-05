using UnityEngine;
using UnityEngine.UI;

public class ResummeScript : MonoBehaviour
{
    public MonitorScript monitor;
    //private string dilatacion;
    //private string borramiento;
    //private string consistencia;
    //private string posicion;
    //private string plano;
    //private string indice;
    //private string madre;

    private Text text;

    private void Start()
    {
        text = GetComponent<Text>();
        //dilatacion = "";
        //borramiento = "";
        //consistencia = "";
        //posicion = "";
        //plano = "";
    }

    private void Update()
    {
        text.text = "Dilatación: " + monitor.Dilatacion + "\n" +
                    "Borramiento: " + monitor.Borramiento + "\n" +
                    "Consistencia: " + monitor.Consistencia + "\n" +
                    "Posicion: " + monitor.Posicion + "\n" +
                    "Plano: " + monitor.Plano+ "\n" +
                    "    Indice de Bishop: " + monitor.Indice + "\n" +
                    "\n" +
                    "Madre " + monitor.Madre;
    }

}
