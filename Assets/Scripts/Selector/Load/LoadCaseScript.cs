using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class LoadCaseScript : MonoBehaviour
{
    public GameObject Container;
    public GameObject button;
    private string[] dirs;
    private string[] name;

    // Start is called before the first frame update
    void Start()
    {
        GameObject button;
        dirs = Directory.GetFiles(@"Casos", "*.txt");
        for (int i=0; i < dirs.Length; i++) { 
            button = (GameObject)Instantiate(this.button);
            button.transform.parent = Container.transform;
<<<<<<< HEAD:Assets/Scripts/Selector/Load/LoadCaseScript.cs
            button.transform.localScale = new Vector3(1, 0.8f, 1);
            button.transform.localPosition = new Vector3(90, (-25f * i) - 20, 0);
            button.GetComponent<ButtonID>().ID = i;
=======
            button.transform.localPosition = new Vector3(0, (-35f * (i+1))-10, 0);
            button.transform.localScale = new Vector3(1, 1, 1);
>>>>>>> parent of 8208cd4... Fixed bugs 2:Assets/LoadCaseScript.cs
            string nombre = dirs[i];
            Debug.Log(nombre.Length);
            nombre = nombre.Remove(0, 6);
            nombre = nombre.Remove(nombre.Length-4);
            button.GetComponentInChildren<Text>().text = nombre;
            }
    }


}
