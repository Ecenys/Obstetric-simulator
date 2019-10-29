using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageRotator : MonoBehaviour
{
    public GameObject image;
    public int position;

    public void Start()
    {
        //image.transform.rotation = Quaternion.Euler(0f, 90f, -90f);
    }
    public void Press()
    {
        image.transform.rotation = Quaternion.Euler(-position, image.transform.rotation.y + 90, image.transform.rotation.z - 90);
    }

    /**
      private void RotateToMouse()
        {   
            //Veriables
            Vector3 ScreenMouse;
            Vector3 ShipPos;

            //Get Mouse Point ON screen
            ScreenMouse.x  = Input.mousePosition.x;
            ScreenMouse.y  = Input.mousePosition.y;
            ScreenMouse.z  = 1;

            //Get Mouse Point In World
            WorldMouse = Camera.main.ScreenToWorldPoint(ScreenMouse);
            //Get Ship Position
            ShipPos = transform.position;

            //Get Angle Of Mouse From Ship Position
            Angle = Mathf.Atan2(ShipPos.z - WorldMouse.z,ShipPos.x - WorldMouse.x) * 180/Mathf.PI;

            transform.localEulerAngles = new Vector3(0,Angle,0);        
         }
    **/
}
