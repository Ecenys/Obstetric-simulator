using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleScript : MonoBehaviour
{
    public GameObject image;

    private int last = 0;

    public void ChangeModel(int id) {
        //Pongo modelo correspondiente
        if(id <= 7)
            //poner modelo 1
            Debug.Log("");
        else if (id == 8)
            //poner modelo 2
            Debug.Log("");
        else if (id == 9)
            //poner modelo 3
            Debug.Log("");

        //Giro modelo correspondiente
        switch (id) {
                case 1:
                    image.transform.localRotation = Quaternion.Euler(270, 0, 0);
                    break;
                case 2:
                    image.transform.localRotation = Quaternion.Euler(250, 0, 0);
                    break;
                case 3:
                    image.transform.localRotation = Quaternion.Euler(230, 0, 0);
                    break;
                case 4:
                    image.transform.localRotation = Quaternion.Euler(210, 0, 0);
                    break;
                case 5:
                    image.transform.localRotation = Quaternion.Euler(190, 0, 0);
                    break;
                case 6:
                    image.transform.localRotation = Quaternion.Euler(180, 0, 0);
                    break;
                case 7:
                    image.transform.localRotation = Quaternion.Euler(0, 0, 90);
                    break;
                case 8:
                    //cambiar modelo a espalda
                    break;
                case 9:
                    //cambiar modelo a nalgas
                    break;

        }
    }
}
