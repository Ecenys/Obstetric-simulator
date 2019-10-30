using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageRotator : MonoBehaviour
{
    public static GameObject image;
    public int position;

    public void Start()
    {
        image = GameObject.Find("Rotator");
        //image.transform.rotation = Quaternion.Euler(0f, 90f, -90f);
    }
    public void Press()
    {
        image.transform.rotation = Quaternion.Euler(0, 0, position - 90);
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
