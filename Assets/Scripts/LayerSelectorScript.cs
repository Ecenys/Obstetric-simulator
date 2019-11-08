using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerSelectorScript : MonoBehaviour
{
    private static int layer;
    private static int maxLayer = 3;
    private static int minLayer = 0;

    private GameObject[] layer1;
    private GameObject[] layer2;
    private GameObject[] layer3;
    private GameObject[] layer0;
    private void Start()
    {
        layer0 = GameObject.FindGameObjectsWithTag("Layer 0");
        layer1 = GameObject.FindGameObjectsWithTag("Layer 1");
        layer2 = GameObject.FindGameObjectsWithTag("Layer 2");
        layer3 = GameObject.FindGameObjectsWithTag("Layer 3");
    }

    private void Update()
    {
        Debug.Log(layer);
    }

    public void Mas() {
        if (layer != maxLayer)
        {
            layer++;
            Cambiar();
        }
    }

    public void Menos() {
        if (layer != minLayer) {
            layer--;
            Cambiar();
        }
    }

    private void Cambiar()
    {
        int i;
        switch (layer)
        {
            case 0:
                for (i = 0; i < layer0.Length; i++)
                    layer0[i].SetActive(true);
                for (i = 0; i < layer1.Length; i++)
                    layer1[i].SetActive(false);
                break;
            case 1:
                for (i = 0; i < layer0.Length; i++)
                    layer0[i].SetActive(false);
                for (i = 0; i < layer1.Length; i++)
                    layer1[i].SetActive(true);
                for (i = 0; i < layer2.Length; i++)
                    layer2[i].SetActive(false);
                break;
            case 2:
                for (i = 0; i < layer1.Length; i++)
                    layer1[i].SetActive(false);
                for (i = 0; i < layer2.Length; i++)
                    layer2[i].SetActive(true);
                for (i = 0; i < layer3.Length; i++)
                    layer3[i].SetActive(false);
                break;
            case 3:
                for (i = 0; i < layer2.Length; i++)
                    layer2[i].SetActive(false);
                for (i = 0; i < layer3.Length; i++)
                    layer3[i].SetActive(true);
                break;
        }
    }
}
