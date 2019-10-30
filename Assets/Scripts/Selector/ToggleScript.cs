using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleScript : MonoBehaviour
{
    public GameObject image;
    public GameObject model1, model2, model3;


    private int last = 0;

    public void ChangeModel(int id) {
        //Pongo modelo correspondiente
        if (id <= 7)
        {
            model1.gameObject.SetActive(true);
            model2.gameObject.SetActive(false);
            model3.gameObject.SetActive(false);
        }
        else if (id == 8)
        {
            model1.gameObject.SetActive(false);
            model2.gameObject.SetActive(true);
            model3.gameObject.SetActive(false);
        }
        else if (id == 9)
        {
            model1.gameObject.SetActive(false);
            model2.gameObject.SetActive(false);
            model3.gameObject.SetActive(true);
        }

        //Giro modelo correspondiente
        switch (id) {
                case 1:
                    image.transform.localRotation = Quaternion.Euler(270, image.transform.rotation.y, image.transform.rotation.z);
                    break;
                case 2:
                    image.transform.localRotation = Quaternion.Euler(250, image.transform.rotation.y, image.transform.rotation.z);
                break;
                case 3:
                    image.transform.localRotation = Quaternion.Euler(230, image.transform.rotation.y, image.transform.rotation.z);
                break;
                case 4:
                    image.transform.localRotation = Quaternion.Euler(210, image.transform.rotation.y, image.transform.rotation.z);
                break;
                case 5:
                    image.transform.localRotation = Quaternion.Euler(190, image.transform.rotation.y, image.transform.rotation.z);
                break;
                case 6:
                    image.transform.localRotation = Quaternion.Euler(180, image.transform.rotation.y, image.transform.rotation.z);
                break;
                case 7:
                    image.transform.localRotation = Quaternion.Euler(image.transform.rotation.x, image.transform.rotation.y, 180);
                    break;
                case 8:
                    image.transform.localRotation = Quaternion.Euler(270, image.transform.rotation.y, image.transform.rotation.z);
                break;
                case 9:
                    image.transform.localRotation = Quaternion.Euler(270, image.transform.rotation.y, image.transform.rotation.z);
                    break;

        }
    }
}
