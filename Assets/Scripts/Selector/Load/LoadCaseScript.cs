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
    private GameObject[] botones;
    private int selecionado;

    // Start is called before the first frame update
    void Start()
    {
        GameObject button;
        dirs = Directory.GetFiles(@"Casos", "*.txt");
        for (int i=0; i < dirs.Length; i++) { 
            button = (GameObject)Instantiate(this.button);
            button.transform.parent = Container.transform;
            button.transform.localScale = new Vector3(1, 0.8f, 1);
            button.transform.localPosition = new Vector3(90, (-25f * i) - 20, 0);
            button.GetComponent<ButtonID>().ID = i;
            string nombre = dirs[i];
            nombre = nombre.Remove(0, 6);
            nombre = nombre.Remove(nombre.Length-4);
            button.GetComponentInChildren<Text>().text = nombre;
            button.GetComponent<ButtonID>().name = nombre;
        }
        botones = GameObject.FindGameObjectsWithTag("LoadButton");
        pressButton(0);
    }

    public void pressButton(int ID)
    {
        selecionado = ID;
        Debug.Log(ID);
        for (int i = 0; i < botones.Length; i++)
        {
            if (botones[i].GetComponent<ButtonID>().ID != ID)
                botones[i].GetComponent<Image>().color = Color.white;
            else
                botones[i].GetComponent<Image>().color = new Color(0.9411765f, 0.5490196f, 0.3960784f, 1);
        }
        
    }

    public string getName() {
        return botones[selecionado].GetComponent<ButtonID>().name;
    }
}
