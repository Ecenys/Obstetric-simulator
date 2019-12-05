using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleScript : MonoBehaviour
{
    public GameObject image;
    public GameObject model1, model2, model3;

    private void Start()
    {
        //image.transform.localRotation = Quaternion.Euler(90, 0, 180);
    }

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
                    image.transform.localRotation = Quaternion.Euler(90, 0, 180);
                    break;
                case 2:
                    image.transform.localRotation = Quaternion.Euler(70, 0, 180);
                break;
                case 3:
                    image.transform.localRotation = Quaternion.Euler(50, 0, 180);
                break;
                case 4:
                    image.transform.localRotation = Quaternion.Euler(30, 0, 180);
                break;
                case 5:
                    image.transform.localRotation = Quaternion.Euler(15, 0, 180);
                break;
                case 6:
                    image.transform.localRotation = Quaternion.Euler(0, 0, 180);
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
