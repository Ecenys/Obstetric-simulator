using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerSelectorScript : MonoBehaviour
{
    private static int layer;
    private static int maxLayer = 3;
    private static int minLayer = 0;

    private void Update()
    {
        Debug.Log(layer);
    }

    public void Mas() {
        if (layer != maxLayer)
        {
            switch (layer)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }
            layer++;
        }
    }

    public void Menos() {
        if (layer != minLayer) {
            switch (layer) {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }
            layer--;
        }
    }
}
