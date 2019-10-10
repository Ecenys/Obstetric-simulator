using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconMove : MonoBehaviour
{

    private double time;
    private bool sequence;

    // Start is called before the first frame update
    void Start()
    {
        sequence = true;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > 7) { //seconds to change the rotation
            sequence = !sequence;
            time = 0;
        }
        if (sequence)
            transform.Rotate(Vector3.back, Time.deltaTime * 2); //velocity
        else
            transform.Rotate(Vector3.forward, Time.deltaTime * 2);
    }
}
