using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuadScript : MonoBehaviour
{
    public Material circle;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Funciono");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Sigo vivo");
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("peneenter");
        circle.color = Color.green;
        //circle.SetColor("_TintColor", Color.green);
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("peneentertrigger");
        circle.color = Color.green;
        //circle.SetColor("_TintColor", Color.green);
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("penesalidatrigger");
        circle.color = Color.red;
        //circle.SetColor("_TintColor", Color.green);
    }


    void OnCollisionExit(Collision collision)
    {

        Debug.Log("penesalir");
        circle.color = Color.red;
        //circle.SetColor("_TintColor", Color.red);
    }
}
